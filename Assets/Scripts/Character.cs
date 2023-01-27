using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Objects;

/// <summary>
/// Character parent class
/// </summary>
public class Character :MonoBehaviour
{
    private DialogueObjectController _dialogBox;
    private int _numDialog;

    public bool InDialog;
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
        public Transform position;
    }

    /// <summary>
    /// Regular Dialog
    /// </summary>
    [TextArea(15, 20)]
    public List<string> DialogueRegularConvo;

    /// <summary>
    /// Dialogue For Interrigation
    /// </summary>
    [TextArea(15, 20)]
    public List<string> DialogueForInterrigation;

    /// <summary>
    /// Interigation Dialog after clue found
    /// </summary>
    [TextArea(15, 20)]
    public List<string> DialogueAfterClue;



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

            if (CorrectClue)
            {

                //DialogueManager.dialogueManager.currentCorrectClue = CorrectClue;
            }            
        }
        else
        {
            _dialogBox.InterrigationMode = false;
        }
        _dialogBox.SpeakerName = Name.ToString();
        _dialogBox.SpeakerImage = Profile;
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

    }
    /// <summary>
    /// hold up one at a time
    /// </summary>
    /// <returns></returns>
    IEnumerator Talk()
    {
        switch (Scene)
        {
            case CurrentScene.Entrance:
                foreach (char c in DialogueRegularConvo[_numDialog].ToCharArray())
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
