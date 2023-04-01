using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

/// <summary>
/// Character parent class
/// </summary>
public class Character :MonoBehaviour
{
    private DialogueObjectController _dialogBox;
    private InterrogationController _interrogationController;
    private Animator _animator;
    private bool imDead;
    [SerializeField]
    private Sprite DeadSprite;
    private int _numDialog;
    private int _numDialogAfterClue;
    private bool _isTalking;
    private bool _inDialog;
    private bool _nterrogationMode;
    private bool _cluePresented;
    private bool _correctCluePresented;
    [SerializeField]
    private Clue correctClue;

    public bool ImDead
    {
        get
        {
            return imDead;
        }        
    }
    /// <summary>
    /// The Element Number of the List we want.
    /// </summary>
    public int NumDialog
    {
        set { _numDialog = value; }
    }
    /// <summary>
    /// I am in dialog.
    /// </summary>
    public bool InDialog
    {
        get{
            return _inDialog;
        }
        set{
            _inDialog = value;
        }
    }

    /// <summary>
    /// Will I interigrated or not
    /// </summary>
    public bool InterrogationMode
    {
        get
        {
            return _nterrogationMode;
        }
        set { _nterrogationMode = value;}
    }

    /// <summary>
    /// List of Scenes
    /// Hardcoded so make sure to add scenes here if any new one
    /// </summary>
    public enum CurrentScene
    {
        None,
        Entrance,
        GrandHall,
        Interrigation,
        BigReveal,
        Test
    }
    /// <summary>
    /// Enum List of Character Names
    /// </summary>
    public enum CharacterName
    {
        Ashlyn,
        Damien,
        Frederick,
        Jayson,
        John,
        Karol,
        Mirianne,
        Nikki,
        OldCrazyMan,
        Robot,
        Rachel
    }
    /// <summary>
    /// Name of Character
    /// </summary>
    [Tooltip("Name of Character")]
    public CharacterName Name;

    /// <summary>
    /// Characters Image for conversation
    /// </summary>
    [Tooltip("Characters image for conversation")]
    public Sprite Profile;

    /// <summary>
    /// Characters Image for interigation
    /// </summary>
    [Tooltip("Characters image for Int")]
    public Sprite InterrigationSprite;

    /// <summary>
    /// If you want the character to spawn in a specifc spot for a scene put it here
    /// Depending on scene
    /// </summary>
    [Tooltip("If you want the character to spawn in a specifc spot for a scene put it here. And other Setup Information")]
    public List<CharacterSetUp> CharacterSetUps;

    /// <summary>
    /// To make sure a character spawns in the position for the scene you can hard code it and save here.
    /// </summary>
    [System.Serializable]
    public class CharacterSetUp
    {
        /// <summary>
        /// Scene the position to take effect in.
        /// </summary>
        public CurrentScene Scene;
        /// <summary>
        /// Position the character to be in for the scene
        /// </summary>
        public Vector2 Position;
        /// <summary>
        /// If Character is dead in the scene or not
        /// </summary>
        public bool IsDead;
    }

    /// <summary>
    /// Regular Dialog
    /// </summary>
    public List<DialogRegularConvo> dialogForRegularConvo;
    [System.Serializable]
    public class DialogRegularConvo
    {
        // Text for Regular Convo
        [TextArea(15, 20)]
        public string Text;
        /// <summary>
        /// If the NPC is talking or the Player is talking.
        /// true = NPC.
        /// false = Player.
        /// </summary>
        public bool NPCTalking;
    }

    /// <summary>
    /// Dialogue For Interrogation
    /// </summary>
    public List<DialogueForInterrogation> DialogueForInterrogations;

    [System.Serializable]
    public class DialogueForInterrogation
    {
        /// <summary>
        /// True is no Question and just talking
        /// </summary>
        public bool NoQuestions;
        /// <summary>
        /// True for when NPC is talking and false for Player Talking
        /// </summary>
        public bool NPCTalking;
        /// <summary>
        /// True to End Interrogation after this Element
        /// </summary>
        public bool EndInterrogation;
        /// <summary>
        /// Next Element to go to YOU ONLY NEED TO PLACE THIS IF YOU HAVE NO QUESTIONS
        /// </summary>
        public int NextElementNumber;
        [TextArea(15, 10)]
        public string Response;
        public Question Question1;
        public Question Question2;
        public Question Question3;

    }
    [System.Serializable]
    public class Question
    {
        public string QuestionText = "No Option";
        /// <summary>
        /// The Next Element in the list to go to if this question is selected
        /// </summary>
        public int NextElementNumber;

        /// <summary>
        /// True for if this option ends interrogation
        /// </summary>
        public bool EndInterrogation;
    }

    /// <summary>
    /// Interigation Dialog after clue found.
    /// DO NOT PUT CORRECT CLUE DIALOGUE FIRST!!!
    /// </summary>
    public List<DialogueAfterClue> DialogueAfterClues;

    [System.Serializable]
    public class DialogueAfterClue
    {
        /// <summary>
        /// Dialogue to show for when correct clue.
        /// </summary>
        public bool CorrectClue;
        /// <summary>
        /// True is no Question and just talking
        /// </summary>
        public bool NoQuestions;
        /// <summary>
        /// True for when NPC is talking and false for Player Talking
        /// </summary>
        public bool NPCTalking;
        /// <summary>
        /// True to End Interrogation after this Element
        /// </summary>
        public bool EndInterrogation;
        /// <summary>
        /// Next Element to go to YOU ONLY NEED TO PLACE THIS IF YOU HAVE NO QUESTIONS
        /// </summary>
        public int NextElementNumber;
        [TextArea(15, 10)]
        public string Response;
        public Question Question1;
        public Question Question2;
        public Question Question3;
    }
    // Start is called before the first frame update
    void Start()
    {       
        _animator=GetComponent<Animator>();
        SetUpForScene(GameManager.Instance.CurrentScene);        
    }

    /// <summary>
    /// Check if Object is in correct Position for the scene
    /// </summary>
    /// <param name="Scene"></param>
    private void SetUpForScene(string Scene)
    {
        switch(Scene)
        {
            case "Entrance":
                InterrogationMode = false;
                SetRegularConvo();
                try
                {
                    CharacterSetUp thisSetup = CharacterSetUps.FirstOrDefault(cs => cs.Scene.ToString() == Scene);
                    this.transform.position = thisSetup.Position;
                    imDead = thisSetup.IsDead;
                    _animator.SetBool("Dead", imDead);
                }
                catch
                {
                    Debug.Log("Error in Character script at setUpForScene");
                }                
                break;
            case "GrandHall":
                InterrogationMode = true;
                SetInterrogationConvo();
                SetAfterClueConvo();
                try
                {
                    CharacterSetUp thisSetup = CharacterSetUps.FirstOrDefault(cs => cs.Scene.ToString() == Scene);
                    this.transform.position = thisSetup.Position;
                    imDead = thisSetup.IsDead;
                    _animator.SetBool("Dead", imDead);
                }
                catch
                {
                    Debug.Log("Error in Character script at setUpForScene");
                }
                break;
            case "InterrogationScene":
                _correctCluePresented= false;
                this.gameObject.transform.position = GameObject.FindGameObjectWithTag("InterrogationController").GetComponent<InterrogationController>().NPCPosition.position;
                InterrogationMode = true;
                SetInterrogationConvo();
                SetAfterClueConvo();
                break;
            default:                
                Debug.LogWarning("No setup written for "+Scene+" in Character Class");
                break;
        }
    }
    /// <summary>
    /// Method is called when loading into Entrance.
    /// Mainly for RegularConvo
    /// </summary>
    public virtual void SetRegularConvo()
    {
        dialogForRegularConvo.Clear();
    }
    /// <summary>
    /// Method for populating the Interrogation Dialogue List
    /// </summary>
    public virtual void SetInterrogationConvo()
    {
        DialogueForInterrogations.Clear();
    }
    /// <summary>
    /// Method for populating the After Clue Dialogue List
    /// </summary>
    public virtual void SetAfterClueConvo()
    {
        DialogueAfterClues.Clear();
    }
    /// <summary>
    /// Start talking
    /// </summary>
    public void StartDialogue()
    {
        if (imDead)
        {

        }
        else
        {
            _dialogBox = GameObject.FindGameObjectWithTag("DialogBox").GetComponent<DialogueObjectController>();

            InDialog = true;

            if (InterrogationMode)
            {
                _interrogationController = GameObject.FindGameObjectWithTag("InterrogationController").GetComponent<InterrogationController>();
                _dialogBox.InterrigationMode = true;
                _dialogBox.SpeakerName = Name.ToString();
                _dialogBox.SpeakerImage = Profile;

            }
            else
            {
                LookAtPlayer(GameObject.FindGameObjectWithTag("Player"));
                _dialogBox.Display(true);
                _dialogBox.Text = "";
                _dialogBox.InterrigationMode = false;
                _dialogBox.SpeakerName = Name.ToString();
                _dialogBox.SpeakerImage = Profile;
            }
            StartCoroutine(Talk());
            _numDialog++;
        }
    }
    /// <summary>
    /// Continue talking
    /// </summary>
    public void ContinueDialogue()
    {
        if (!_isTalking)
        {
            // temp holders
            bool EndInterrogation;
            bool EndInterrogationForClue;
            try
            {
                EndInterrogation = DialogueForInterrogations[_numDialog].EndInterrogation;
            }
            catch
            {
                EndInterrogation = false;
            }            
            try
            {
                EndInterrogationForClue = DialogueAfterClues[_numDialogAfterClue].EndInterrogation && _cluePresented;
            }
            catch
            {
                EndInterrogationForClue= false;
            }            

            if ((EndInterrogation && InterrogationMode) ||
                dialogForRegularConvo.Count <= _numDialog && !InterrogationMode ||
                (EndInterrogationForClue && InterrogationMode))                                 
            {               

                if (!InterrogationMode)
                {
                    GameObject.Find("Player").GetComponent<Player>().Talking = false;
                    _animator.SetBool("Up", false);
                    _animator.SetBool("Down", false);
                    _animator.SetBool("Left", false);
                    _animator.SetBool("Right", false);                    
                }
                else
                {
                    StartCoroutine(FinalDialogue());
                }                    
            }
            else
            {
                _dialogBox.Text = "";

                if (InterrogationMode)
                {
                    if (DialogueForInterrogations[_numDialog].NPCTalking || (DialogueAfterClues[_numDialogAfterClue].NPCTalking && _cluePresented))
                    {
                        _dialogBox.SpeakerName = Name.ToString();
                        _dialogBox.SpeakerImage = Profile;
                    }
                    else
                        _interrogationController.PlayerTalking();
                }
                else
                {
                    if (dialogForRegularConvo[_numDialog].NPCTalking)
                    {
                        _dialogBox.SpeakerName = Name.ToString();
                        _dialogBox.SpeakerImage = Profile;
                    }
                    else
                        GameObject.Find("Player").GetComponent<Player>().ImTalking();
                }

                StartCoroutine(Talk());
                if (_cluePresented)
                {                    
                    if (EndInterrogationForClue)
                        _cluePresented = false;
                    else
                        _numDialogAfterClue++;
                }
                else
                    _numDialog++;
            }
        }        
    }
    /// <summary>
    /// Checks if right clue to present to Character
    /// </summary>
    /// <param name="clue">Send the Clue over</param>
    public void PresentClue(Clue clue)
    {
        if(clue.name == correctClue.name)
            _correctCluePresented= true;
        else
            _correctCluePresented = false;

        _cluePresented= true;
        _numDialogAfterClue = 0;
        ContinueDialogue();
    }
    private void LookAtPlayer(GameObject Player)
    {
        Vector2 direction = Player.transform.position - transform.position;
        if (Mathf.Abs(direction.x) > Mathf.Abs(direction.y))
        {
            if (direction.x > 0)
            {
                _animator.SetBool("Up", false);
                _animator.SetBool("Down", false);
                _animator.SetBool("Left", false);
                _animator.SetBool("Right", true);                
            }
            else
            {
                _animator.SetBool("Up", false);
                _animator.SetBool("Down", false);
                _animator.SetBool("Left", true);
                _animator.SetBool("Right", false);
            }
        }
        else
        {
            if (direction.y > 0)
            {
                _animator.SetBool("Up", true);
                _animator.SetBool("Down", false);
                _animator.SetBool("Left", false);
                _animator.SetBool("Right", false);
            }
            else
            {
                _animator.SetBool("Up", false);
                _animator.SetBool("Down", true);
                _animator.SetBool("Left", false);
                _animator.SetBool("Right", false);
            }
        }
    }
    /// <summary>
    /// hold up one at a time.
    /// And all other Dialogue
    /// </summary>
    /// <returns></returns>
    IEnumerator Talk()
    {
        _isTalking = true;
        switch (SceneManager.GetActiveScene().name)
        {
            case "Entrance":
                foreach (char c in dialogForRegularConvo[_numDialog].Text.ToCharArray())
                {
                    _dialogBox.Text += c;
                    yield return new WaitForSeconds(0.02f);
                }
                break;
            case "InterrogationScene":
                if (_cluePresented)
                {
                    if (_correctCluePresented)
                    {
                        //temp for now to adjust later for polish
                        bool find = true; ;
                        while (find)
                        {
                            if (DialogueAfterClues[_numDialogAfterClue].CorrectClue)
                            {
                                if (DialogueAfterClues[_numDialogAfterClue].NoQuestions)
                                {
                                    _dialogBox.SwitchMode(false);
                                    //_dialogBox.Text = DialogueAfterClues[_numDialog].Response;
                                    //_interrogationController.NextElementForInterrogating = DialogueAfterClues[_numDialog].NextElementNumber;
                                    foreach (char c in DialogueAfterClues[_numDialogAfterClue].Response.ToCharArray())
                                    {
                                        _dialogBox.Text += c;
                                        yield return new WaitForSeconds(0.02f);
                                    }
                                }
                                else
                                {
                                    _dialogBox.SwitchMode(true);
                                    _dialogBox.Text = DialogueAfterClues[_numDialogAfterClue].Response;
                                    _dialogBox.SetUpQuestions(1, DialogueAfterClues[_numDialogAfterClue].Question1.QuestionText, DialogueAfterClues[_numDialogAfterClue].Question1.NextElementNumber, DialogueAfterClues[_numDialogAfterClue].Question1.EndInterrogation);
                                    _dialogBox.SetUpQuestions(2, DialogueAfterClues[_numDialogAfterClue].Question2.QuestionText, DialogueAfterClues[_numDialogAfterClue].Question2.NextElementNumber, DialogueAfterClues[_numDialogAfterClue].Question2.EndInterrogation);
                                    _dialogBox.SetUpQuestions(3, DialogueAfterClues[_numDialogAfterClue].Question3.QuestionText, DialogueAfterClues[_numDialogAfterClue].Question3.NextElementNumber, DialogueAfterClues[_numDialogAfterClue].Question3.EndInterrogation);
                                }
                                find = false;
                            }
                            else
                                _numDialogAfterClue++;
                        }
                    }
                    else
                    {
                        //foreach (char c in DialogueAfterClues[_numDialog].Response.ToCharArray())
                        //{
                        //    _dialogBox.Text += c;
                        //    yield return new WaitForSeconds(0.02f);
                        //}
                        if (DialogueAfterClues[_numDialogAfterClue].NoQuestions)
                        {
                            _dialogBox.SwitchMode(false);
                            //_dialogBox.Text = DialogueAfterClues[_numDialog].Response;
                            //_interrogationController.NextElementForInterrogating = DialogueAfterClues[_numDialog].NextElementNumber;
                            foreach (char c in DialogueAfterClues[_numDialogAfterClue].Response.ToCharArray())
                            {
                                _dialogBox.Text += c;
                                yield return new WaitForSeconds(0.02f);
                            }
                        }
                        else
                        {
                            _dialogBox.SwitchMode(true);
                            _dialogBox.Text = DialogueAfterClues[_numDialogAfterClue].Response;
                            _dialogBox.SetUpQuestions(1, DialogueAfterClues[_numDialogAfterClue].Question1.QuestionText, DialogueAfterClues[_numDialogAfterClue].Question1.NextElementNumber, DialogueAfterClues[_numDialogAfterClue].Question1.EndInterrogation);
                            _dialogBox.SetUpQuestions(2, DialogueAfterClues[_numDialogAfterClue].Question2.QuestionText, DialogueAfterClues[_numDialogAfterClue].Question2.NextElementNumber, DialogueAfterClues[_numDialogAfterClue].Question2.EndInterrogation);
                            _dialogBox.SetUpQuestions(3, DialogueAfterClues[_numDialogAfterClue].Question3.QuestionText, DialogueAfterClues[_numDialogAfterClue].Question3.NextElementNumber, DialogueAfterClues[_numDialogAfterClue].Question3.EndInterrogation);
                        }
                    }
                }
                else
                {
                    if (DialogueForInterrogations[_numDialog].NoQuestions)
                    {
                        _dialogBox.SwitchMode(false);
                        _dialogBox.Text = DialogueForInterrogations[_numDialog].Response;
                        _interrogationController.NextElementForInterrogating = DialogueForInterrogations[_numDialog].NextElementNumber;
                    }
                    else
                    {
                        _dialogBox.SwitchMode(true);
                        _dialogBox.Text = DialogueForInterrogations[_numDialog].Response;
                        _dialogBox.SetUpQuestions(1, DialogueForInterrogations[_numDialog].Question1.QuestionText, DialogueForInterrogations[_numDialog].Question1.NextElementNumber, DialogueForInterrogations[_numDialog].Question1.EndInterrogation);
                        _dialogBox.SetUpQuestions(2, DialogueForInterrogations[_numDialog].Question2.QuestionText, DialogueForInterrogations[_numDialog].Question2.NextElementNumber, DialogueForInterrogations[_numDialog].Question2.EndInterrogation);
                        _dialogBox.SetUpQuestions(3, DialogueForInterrogations[_numDialog].Question3.QuestionText, DialogueForInterrogations[_numDialog].Question3.NextElementNumber, DialogueForInterrogations[_numDialog].Question3.EndInterrogation);
                    }
                }
                break;
            default:
                Debug.LogError("No Talking Dialog for " + GameManager.Instance.CurrentScene);
                break;
        }
        _isTalking = false;
    }
    /// <summary>
    /// Handles Final Dialogue
    /// </summary>
    /// <returns></returns>
    IEnumerator FinalDialogue()
    {
        if (_cluePresented)
        {
            if (_correctCluePresented)
            {
                //temp for now to adjust later for polish
                bool find = true; ;
                while (find)
                {
                    if (DialogueAfterClues[_numDialogAfterClue].CorrectClue)
                    {
                        if (DialogueAfterClues[_numDialogAfterClue].NoQuestions)
                        {
                            _dialogBox.SwitchMode(false);
                            //_dialogBox.Text = DialogueAfterClues[_numDialog].Response;
                            //_interrogationController.NextElementForInterrogating = DialogueAfterClues[_numDialog].NextElementNumber;
                            foreach (char c in DialogueAfterClues[_numDialogAfterClue].Response.ToCharArray())
                            {
                                _dialogBox.Text += c;
                                yield return new WaitForSeconds(0.02f);
                            }
                        }
                        else
                        {
                            _dialogBox.SwitchMode(true);
                            _dialogBox.Text = DialogueAfterClues[_numDialogAfterClue].Response;
                            _dialogBox.SetUpQuestions(1, DialogueAfterClues[_numDialogAfterClue].Question1.QuestionText, DialogueAfterClues[_numDialogAfterClue].Question1.NextElementNumber, DialogueAfterClues[_numDialogAfterClue].Question1.EndInterrogation);
                            _dialogBox.SetUpQuestions(2, DialogueAfterClues[_numDialogAfterClue].Question2.QuestionText, DialogueAfterClues[_numDialogAfterClue].Question2.NextElementNumber, DialogueAfterClues[_numDialogAfterClue].Question2.EndInterrogation);
                            _dialogBox.SetUpQuestions(3, DialogueAfterClues[_numDialogAfterClue].Question3.QuestionText, DialogueAfterClues[_numDialogAfterClue].Question3.NextElementNumber, DialogueAfterClues[_numDialogAfterClue].Question3.EndInterrogation);
                        }
                        find = false;
                    }
                    else
                        _numDialogAfterClue++;
                }
            }
            else
            {
                //foreach (char c in DialogueAfterClues[_numDialog].Response.ToCharArray())
                //{
                //    _dialogBox.Text += c;
                //    yield return new WaitForSeconds(0.02f);
                //}
                if (DialogueAfterClues[_numDialogAfterClue].NoQuestions)
                {
                    _dialogBox.SwitchMode(false);
                    //_dialogBox.Text = DialogueAfterClues[_numDialog].Response;
                    //_interrogationController.NextElementForInterrogating = DialogueAfterClues[_numDialog].NextElementNumber;
                    foreach (char c in DialogueAfterClues[_numDialogAfterClue].Response.ToCharArray())
                    {
                        _dialogBox.Text += c;
                        yield return new WaitForSeconds(0.02f);
                    }
                }
                else
                {
                    _dialogBox.SwitchMode(true);
                    _dialogBox.Text = DialogueAfterClues[_numDialogAfterClue].Response;
                    _dialogBox.SetUpQuestions(1, DialogueAfterClues[_numDialogAfterClue].Question1.QuestionText, DialogueAfterClues[_numDialogAfterClue].Question1.NextElementNumber, DialogueAfterClues[_numDialogAfterClue].Question1.EndInterrogation);
                    _dialogBox.SetUpQuestions(2, DialogueAfterClues[_numDialogAfterClue].Question2.QuestionText, DialogueAfterClues[_numDialogAfterClue].Question2.NextElementNumber, DialogueAfterClues[_numDialogAfterClue].Question2.EndInterrogation);
                    _dialogBox.SetUpQuestions(3, DialogueAfterClues[_numDialogAfterClue].Question3.QuestionText, DialogueAfterClues[_numDialogAfterClue].Question3.NextElementNumber, DialogueAfterClues[_numDialogAfterClue].Question3.EndInterrogation);
                }
            }
        }
        else
        {
            if (DialogueForInterrogations[_numDialog].NoQuestions)
            {
                _dialogBox.SwitchMode(false);
                foreach(char c in DialogueForInterrogations[_numDialog].Response.ToCharArray())
                {
                    _dialogBox.Text += c;
                    yield return new WaitForSeconds(0.02f);
                }
                _interrogationController.NextElementForInterrogating = DialogueForInterrogations[_numDialog].NextElementNumber;
            }
            else
            {
                _dialogBox.SwitchMode(true);
                _dialogBox.Text = DialogueForInterrogations[_numDialog].Response;
                _dialogBox.SetUpQuestions(1, DialogueForInterrogations[_numDialog].Question1.QuestionText, DialogueForInterrogations[_numDialog].Question1.NextElementNumber, DialogueForInterrogations[_numDialog].Question1.EndInterrogation);
                _dialogBox.SetUpQuestions(2, DialogueForInterrogations[_numDialog].Question2.QuestionText, DialogueForInterrogations[_numDialog].Question2.NextElementNumber, DialogueForInterrogations[_numDialog].Question2.EndInterrogation);
                _dialogBox.SetUpQuestions(3, DialogueForInterrogations[_numDialog].Question3.QuestionText, DialogueForInterrogations[_numDialog].Question3.NextElementNumber, DialogueForInterrogations[_numDialog].Question3.EndInterrogation);
            }
        }
        yield return new WaitForSeconds(8.0f);

        InDialog = false;
        _dialogBox.Display(false);
        _numDialog = 0;

        SceneManager.LoadScene("GrandHall");
    }
}
