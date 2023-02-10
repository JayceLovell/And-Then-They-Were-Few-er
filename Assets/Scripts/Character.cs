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
    private int _numDialog;
    private bool _isTalking;
    private bool _inDialog;
    [SerializeField]
    private Sprite SpriteUp;
    [SerializeField]
    private Sprite SpriteDown;
    [SerializeField]
    private Sprite SpriteLeft;
    [SerializeField]
    private Sprite SpriteRight;

    public int NumDialog
    {
        set { _numDialog = value; }
    }
    public bool InDialog
    {
        get{
            return _inDialog;
        }
        set{
            _inDialog = value;
        }
    }

    public bool InterrigrationMode;

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
        Rachel
    }

    [Tooltip("Name of Character")]
    public CharacterName Name;

    public Clue CorrectClue;

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
    [Tooltip("If you want the character to spawn in a specifc spot for a scene put it here.")]
    public List<CharacterPosition> characterPosition;

    [System.Serializable]
    public class CharacterPosition
    {
        public CurrentScene Scene;
        public Vector2 Position;
    }

    /// <summary>
    /// Regular Dialog
    /// </summary>
    public List<DialogRegularConvo> dialogForRegularConvo;
    [System.Serializable]
    public class DialogRegularConvo
    {
        [TextArea(15, 20)]
        public string Text;
        public bool NPCTalking;
    }

    /// <summary>
    /// Dialogue For Interrogation
    /// </summary>
    public List<DialogueForInterrogation> DialogueForInterrogations;

    [System.Serializable]
    public class DialogueForInterrogation
    {
        public bool NoQuestions;
        public bool PlayerTalk;
        public bool EndInterrogation;        
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
        public int NextElementNumber;
    }

    /// <summary>
    /// Interigation Dialog after clue found
    /// </summary>
    public List<DialogueAfterClue> dialogueAfterClue;

    [System.Serializable]
    public class DialogueAfterClue
    {
        public bool NoQuestions;
        public bool PlayerTalk;
        public bool EndInterrogation;
        public int NextElementNumber;
        [TextArea(15, 10)]
        public string Response;
        public Question Question1;
        public Question Question2;
        public Question Question3;
    }
    // Start is called before the first frame update
    public virtual void Start()
    {       
        _animator=GetComponent<Animator>();
        setUpForScene(GameManager.Instance.CurrentScene);
    }

    /// <summary>
    /// Check if Object is in correct Position for the scene
    /// </summary>
    /// <param name="Scene"></param>
    public virtual void setUpForScene(string Scene)
    {
        switch(Scene)
        {
            case "GrandHall":
                InterrigrationMode = true;
                break;
            case "InterrogationScene":
                this.gameObject.transform.position = GameObject.FindGameObjectWithTag("InterrogationController").GetComponent<InterrogationController>().NPCPosition.position;
                break;
        }
    }

    /// <summary>
    /// Method for populating the Interrogation Dialogue List
    /// </summary>
    public virtual void SetInterrogationConvo()
    {

    }
    /// <summary>
    /// Start talking
    /// </summary>
    public void StartDialogue()
    {
        _dialogBox = GameObject.FindGameObjectWithTag("DialogBox").GetComponent<DialogueObjectController>();

        InDialog = true;

        LookAtPlayer(GameObject.FindGameObjectWithTag("Player"));

        if (InterrigrationMode)
        {
            _interrogationController = GameObject.FindGameObjectWithTag("InterrogationController").GetComponent<InterrogationController>();
            _dialogBox.InterrigationMode = true;
            _dialogBox.SpeakerName = Name.ToString();
            _dialogBox.SpeakerImage = Profile;

        }
        else
        {
            _dialogBox.InterrigationMode = false;
            _dialogBox.SpeakerName = Name.ToString();
            _dialogBox.SpeakerImage = Profile;
        }
        StartCoroutine(Talk());
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
                EndInterrogationForClue = dialogueAfterClue[_numDialog].EndInterrogation;
            }
            catch
            {
                EndInterrogationForClue= false;
            }
            // Reminder to fix logic for this statement
            if ((EndInterrogation && InterrigrationMode) ||
                dialogForRegularConvo.Count <= _numDialog && !InterrigrationMode ||
                (EndInterrogationForClue && InterrigrationMode))                 
            {
                InDialog = false;
                _dialogBox.Display(false);
                _numDialog= 0;

                if (!InterrigrationMode)
                {
                    GameObject.Find("Player").GetComponent<Player>().Talking = false;
                    _animator.SetBool("Up", false);
                    _animator.SetBool("Down", false);
                    _animator.SetBool("Left", false);
                    _animator.SetBool("Right", false);
                }
                else
                    SceneManager.LoadScene("GrandHall");
            }
            else
            {
                _dialogBox.Text = "";

                if (InterrigrationMode)
                {
                    _dialogBox.SpeakerName = Name.ToString();
                    _dialogBox.SpeakerImage = Profile;
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
                _numDialog++;
            }
        }        
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
    /// hold up one at a time
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
                _numDialog++;
                break;
            case "InterrogationScene":
                if (_dialogBox.currentClue == CorrectClue)
                {
                    foreach (char c in dialogueAfterClue[_numDialog].Response.ToCharArray())
                    {
                        _dialogBox.Text += c;
                        yield return new WaitForSeconds(0.02f);
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
                        _dialogBox.SetUpQuestions(1, DialogueForInterrogations[_numDialog].Question1.QuestionText, DialogueForInterrogations[_numDialog].Question1.NextElementNumber);
                        _dialogBox.SetUpQuestions(2, DialogueForInterrogations[_numDialog].Question2.QuestionText, DialogueForInterrogations[_numDialog].Question2.NextElementNumber);
                        _dialogBox.SetUpQuestions(3, DialogueForInterrogations[_numDialog].Question3.QuestionText, DialogueForInterrogations[_numDialog].Question3.NextElementNumber);
                    }
                }
                break;
            default:
                Debug.LogError("No Talking Dialog for " + GameManager.Instance.CurrentScene);
                break;
        }
        _isTalking = false;
    }
}
