using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using static Character;

/// <summary>
/// Object parent class
/// </summary>
public class Objects : MonoBehaviour
{
    private bool NoMoreTalk;
    protected bool InDialog;
    protected int _index = 0;
    protected DialogueObjectController _dialogueObjectController;
    protected GameController _gameController;

    [Tooltip("Only fill these out if clue is selected")]
    [Header("Clue stuff")]
    public string ClueStatementText;
    public Clue ClueStatement;

    public DialogueObjectController dialogueObjectController
    {
        get
        {
            return _dialogueObjectController;
        }
        set
        {
            _dialogueObjectController = value;
        }
    }

    public enum TypeOfObject
    {
        Door,
        Chair,
        Clue,
        Placeholder,
        SecretBookShelf,
        StairsToSecretRoom,
        RoomSwitch,
        PlayerReadyTrigger,
        JukeBox,
        LightMachine,
        Fountain
    }
    [Space(10)]
    public TypeOfObject objectType;

    /// <summary>
    /// Dialogue For Interrogation
    /// </summary>
    public List<DialogueForObjects> DialogueForObject;

    [System.Serializable]
    public class DialogueForObjects
    {
        /// <summary>
        /// True for when Ashlyn just talking.
        /// False for when object is giving options for Ashlyn to Respond to.
        /// </summary>
        public bool JustAshlynTalking;
        /// <summary>
        /// True to End Interaction with object after this Element
        /// </summary>
        public bool EndInteraction = false;
        /// <summary>
        /// Next Element to go to.
        /// </summary>
        public int NextElementNumber;

        /// <summary>
        /// What to display above the options for the player.
        /// Or
        /// Just want text to display.
        /// </summary>
        [TextArea(15, 10)]
        public string Text;
        /// <summary>
        /// OptionText 1
        /// </summary>
        public Options Option1;
        /// <summary>
        /// OptionText 2
        /// </summary>
        public Options Option2;
        /// <summary>
        /// OptionText 3
        /// </summary>
        public Options Option3;

    }
    [System.Serializable]
    public class Options
    {
        /// <summary>
        /// What the option is.
        /// </summary>
        public string OptionText = "No Option";
        /// <summary>
        /// Number OptionText Selected
        /// </summary>
        public int OptionSelectedInteger;
        /// <summary>
        /// Next Element to go to after selecting options
        /// </summary>
        public int NextElementNumber;
    }
    // Start is called before the first frame update
    protected virtual void Start()
    {
        _gameController = GameObject.Find("GameController").GetComponent<GameController>();

        if(objectType == TypeOfObject.Clue)
            switch (GameManager.Instance.PlayerProgress)
            {
                case GameManager.GameState.BeforeMurder:
                    this.gameObject.SetActive(false);
                break;
                case GameManager.GameState.AfterMurder:
                    if (ClueStatement.PickedUp)
                        this.gameObject.SetActive(false);
                    break;
            }       

        SetUpDialogue();

        InDialog = false;
        NoMoreTalk = false;
    }
    /// <summary>
    /// Default class for using an object
    /// </summary>
    public virtual void Use()
    {
        if (!InDialog && !NoMoreTalk)
        {
            SetUpDialogue();
            if (_index == 0)
                _dialogueObjectController.Display(true);
            StartCoroutine(Display());
        }
        else
            // Release player
            GameObject.Find("Player").GetComponent<Player>().Talking = false;
    }
    protected virtual void SetUpDialogue()
    {
        DialogueForObject.Clear();
    }
    /// <summary>
    /// Called when option selected
    /// You have to write this in the object itself script not here in Objects script!
    /// </summary>
    /// <param name="index">OptionNumber</param>
    virtual public void OptionSelected(int index)
    {
        Debug.Log("Option Selected for " + gameObject.name);
    }

    IEnumerator Display()
    {
        _dialogueObjectController.Text = "";
        InDialog = true;

        if (DialogueForObject[_index].JustAshlynTalking)
        {
            _dialogueObjectController.SwitchMode(false);

            foreach (char c in DialogueForObject[_index].Text.ToCharArray())
            {
                _dialogueObjectController.Text += c;
                yield return new WaitForSeconds(0.02f);
            }
            yield return new WaitForSeconds(0.5f);
        }
        else
        {
            _dialogueObjectController.SwitchMode(true);
            _dialogueObjectController.Text = DialogueForObject[_index].Text;
            try {
                _dialogueObjectController.SetUpQuestions(1, DialogueForObject[_index].Option1.OptionText, this.gameObject);
            }
            catch
            {
                _dialogueObjectController.SetUpQuestions(1, "No Option");
            }
            try
            {
                _dialogueObjectController.SetUpQuestions(2, DialogueForObject[_index].Option2.OptionText, this.gameObject);
            }
            catch
            {
                _dialogueObjectController.SetUpQuestions(2, "No Option");
            }
            try
            {
                _dialogueObjectController.SetUpQuestions(3, DialogueForObject[_index].Option3.OptionText, this.gameObject);
            }
            catch
            {
                _dialogueObjectController.SetUpQuestions(3, "No Option");                
            }                        
        }

        InDialog = false;

        if (DialogueForObject[_index].EndInteraction)
        {
            NoMoreTalk = true;
            _index = 0;
            
            // Release player
            GameObject.Find("Player").GetComponent<Player>().Talking = false;

            //Remove Clue from game
            if (objectType == TypeOfObject.Clue)
            {
                ClueManager.Instance.AddClue(ClueStatement);                
                Destroy(this.gameObject);
            }

            //Remove DialogueBox if player havn't move
            yield return new WaitForSeconds(2.0f);
            _dialogueObjectController.Display(false);
            NoMoreTalk = false;

        }
        else
          _index++;

    }
}
