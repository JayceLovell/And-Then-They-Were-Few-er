using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;
using static Character;

/// <summary>
/// Character parent class
/// </summary>
public class Character :MonoBehaviour
{
    private DialogueObjectController _dialogBox;
    private int _numDialog;
    private bool _isTalking;
    private bool _inDialog;
    private InterrogationController _interrogationController;

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


    ///// <summary>
    ///// Characters trust level with player
    ///// </summary>
    //[Range(0, 10)]
    //[Tooltip("Characters Trust level")]
    //public int TrustLevel;

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
        public bool ImTalking;
    }

    /// <summary>
    /// Dialogue For Interrogation
    /// </summary>
    public List<DialogueForInterrogation> DialogueForInterrogations;

    [System.Serializable]
    public class DialogueForInterrogation
    {
        public bool NoQuestions;
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
        [TextArea(15, 20)]
        public string Response;
        public string Question1;
        public string Question2;
        // public Question Question3;
    }
    // Start is called before the first frame update
    void Start()
    {
        _positionCheck(GameManager.Instance.CurrentScene);
    }
    /// <summary>
    /// Check if Object is in correct Position for the scene
    /// </summary>
    /// <param name="Scene"></param>
    private void _positionCheck(string Scene)
    {
        switch(Scene)
        {
            case "InterrogationScene":
                this.gameObject.transform.position = GameObject.FindGameObjectWithTag("InterrogationController").GetComponent<InterrogationController>().NPCPosition.position;
                break;
        }
    }
    public void StartDialogue()
    {
        _dialogBox = GameObject.FindGameObjectWithTag("DialogBox").GetComponent<DialogueObjectController>();

        InDialog = true;


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
    public void ContinueDialogue()
    {
        if (!_isTalking)
        {
            // MUST FIX THIS IF STATEMENT
            if ((DialogueForInterrogations[_numDialog].EndInterrogation && InterrigrationMode) ||
                dialogForRegularConvo.Count < _numDialog && !InterrigrationMode)                 
            {
                InDialog = false;
                _dialogBox.Display(false);
                _numDialog= 0;

                if (!InterrigrationMode)
                    GameObject.Find("Player").GetComponent<Player>().Talking = false;
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
                    if (dialogForRegularConvo[_numDialog].ImTalking)
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
    /// <summary>
    /// hold up one at a time
    /// </summary>
    /// <returns></returns>
    IEnumerator Talk()
    {
        _isTalking = true;
        switch (GameManager.Instance.CurrentScene)
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
                if (CorrectClue)
                {
                    //foreach (char c in dialogueAfterClue[_numDialog].Text.ToCharArray())
                    //{
                    //    _dialogBox.Text += c;
                    //    yield return new WaitForSeconds(0.02f);
                    //}
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
    ///// <summary>
    ///// returns a string of the characters name and trust level.
    ///// </summary>
    ///// <returns>string</returns>
    //public string Trust()
    //{
    //    return Name + "trust level is " + TrustLevel+".";
    //}
}
