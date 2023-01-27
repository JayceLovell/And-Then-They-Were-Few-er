using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using static Objects;

/// <summary>
/// Character parent class
/// </summary>
public class Character :MonoBehaviour
{
    private DialogueObjectController _dialogBox;
    private int _numDialog;
    private bool _isTalking;
    private bool _inDialog;

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

    /// <summary>
    /// Scene selected for characters
    /// </summary>
    [Tooltip("Current Scene Character is in")]
    public CurrentScene Scene;

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
    /// Dialogue For Interrigation
    /// </summary>
    public List<DialogueForInterrigation> dialogueForInterrigations;
    [System.Serializable]
    public class DialogueForInterrigation
    {
        [TextArea(15, 20)]
        public string Text;
        public bool ImTalking;
    }

    /// <summary>
    /// Interigation Dialog after clue found
    /// </summary>
    public List<DialogueAfterClue> dialogueAfterClue;
    [System.Serializable]
    public class DialogueAfterClue
    {
        [TextArea(15, 20)]
        public string Text;
        public bool ImTalking;
    }



    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartDialogue()
    {
        _dialogBox = GameObject.FindGameObjectWithTag("DialogBox").GetComponent<DialogueObjectController>();

        InDialog = true;


        if (InterrigrationMode)
        {
            _dialogBox.InterrigationMode = true;

            if(GameManager.Instance.CurrentScene==Scene.ToString())
            {

            }

            if (CorrectClue)
            {

                //DialogueManager.dialogueManager.currentCorrectClue = CorrectClue;
            }
        }
        else
        {
            _dialogBox.InterrigationMode = false;
            _dialogBox.SpeakerName = Name.ToString();
            _dialogBox.SpeakerImage = Profile;
        }
        StartCoroutine(Talk());
        _numDialog++;
    }

    //to be called when the player presents the person being interrogated with the right clue
    public void StartPostClueDialogue()
    {
        //DialogueManager.dialogueManager.CloseTextBox();
        DialogueManager.dialogueManager.inDialogue = true;
        DialogueManager.dialogueManager.inInterrogation = true;
        //DialogueManager.dialogueManager.currentDialogue.RemoveRange(0, DialogueManager.dialogueManager.currentDialogue.Count);
        //DialogueManager.dialogueManager.currentDialogue = dialogueAfterClue;
        DialogueManager.dialogueManager.index = 0;
        DialogueManager.dialogueManager.OpenTextBox();
    }
    public void ContinueDialogue()
    {
        if (!_isTalking)
        {
            if (dialogForRegularConvo.Count == _numDialog)
            {
                _dialogBox.Display();
                _numDialog= 0;
                GameObject.Find("Player").GetComponent<Player>().Talking = false;
            }
            else
            {
                _dialogBox.Text = "";
                if (dialogForRegularConvo[_numDialog].ImTalking)
                {
                    _dialogBox.SpeakerName = Name.ToString();
                    _dialogBox.SpeakerImage = Profile;
                }
                else
                    GameObject.Find("Player").GetComponent<Player>().ImTalking();

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
        switch (Scene)
        {
            case CurrentScene.Entrance:
                foreach (char c in dialogForRegularConvo[_numDialog].Text.ToCharArray())
                {
                    _dialogBox.Text += c;
                    yield return new WaitForSeconds(0.02f);
                }
                break;
            case CurrentScene.GrandHall:
                break;
            case CurrentScene.Interrigation:
                break;
            default:
                Debug.LogError("No Talking Dialog for current scene");
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
    /// <summary>
    /// use this method by
    /// StartCoroutine(WaitInSeconds());
    /// </summary>
    /// <param name="seconds"></param>
    /// <returns>no resumes code</returns>
    IEnumerator WaitInSeconds(float seconds)
    {
        yield return new WaitForSeconds(seconds);
    }
}
