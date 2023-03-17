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
    protected bool InDialog;
    protected int _index = 0;
    protected DialogueObjectController _dialogueObjectController;
    protected GameController _gameController;

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
        JukeBox
    }

    public TypeOfObject objectType;

    public String Dialog;

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
        public bool EndInteraction;
        /// <summary>
        /// Next Element to go to YOU ONLY NEED TO PLACE THIS IF YOU HAVE NO Options
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
        SetUpDialogue();
        InDialog = false;
    }
    /// <summary>
    /// Default class for using an object
    /// </summary>
    public virtual void Use()
    {
        if (!InDialog)
        {
            if (_index == 0)
                _dialogueObjectController.Display(true);
            StartCoroutine(Display());
        }
    }
    protected virtual void SetUpDialogue()
    {
        Debug.Log("Setting up Dialog for "+gameObject.name);
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
            yield return new WaitForSeconds(1.0f);
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
            _index = 0;
            GameObject.Find("Player").GetComponent<Player>().Talking = false;
        }
        else
          _index++;

    }
}
