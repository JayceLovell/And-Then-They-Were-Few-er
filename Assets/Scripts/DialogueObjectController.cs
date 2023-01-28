using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueObjectController : MonoBehaviour
{
    private bool _isInterrigation;
    private string _text;
    private string _question1;
    private string _question2;
    private string _question3;
    private string _speakerName;
    private Sprite _speakerImage;
    private InterrogationController _interrogationController;
    private string _selectedOption;

    /// <summary>
    /// When bool is set.
    /// SetUpObject for mode.
    /// </summary>
    public bool InterrigationMode
    {
        get { return _isInterrigation; }
        set { 
            _isInterrigation = value;
            Display();
            if (InterrigationMode)
            {
                _interrogationController = GameObject.FindGameObjectWithTag("InterrogationController").GetComponent<InterrogationController>();
                SwitchMode(value);
            }
            else
            {
                SwitchMode(value);
            }
        }
    }
    
    /// <summary>
    /// Display Text to right Objects
    /// </summary>
    public string Text
    {
        get { return _text; }
        set
        {
            // Justincase
            Display();

            _text = value;
            if (InterrigationMode)
            {
                InterrigationTextBox.text= value;
            }
            else
            {
                SpeechTextBox.text= value;
            }
        }
    }
    public string Question1
    {
        set
        {
            _question1 = value;
            Option1.text = _question1;
        }
    }
    public string Question2
    {
        set
        {
            _question2 = value;
            Option2.text = _question2;
        }
    }
    public string Question3
    {
        set
        {
            _question3 = value;
            Option3.text = _question3;
        }
    }
    
    /// <summary>
    /// Send Name here
    /// </summary>
    public string SpeakerName
    {
        set { 
            _speakerName = value;
            SpeakerLabel.text = value;
        }
    }
    
    /// <summary>
    /// Send Image Here!
    /// </summary>
    public Sprite SpeakerImage
    {
        set
        {
            _speakerImage = value;
            SpeakerProfile.sprite = value;
        }
    }

    public string SelectedOption
    {
        get { return _selectedOption; }
        set
        {
            _selectedOption = value;
        }
    }

    [Header("Who is talking?")]
    /// <summary>
    /// DO NOT SEND NAME HERE
    /// </summary>
    [SerializeField]
    private TextMeshProUGUI SpeakerLabel;

    /// <summary>
    /// DO NOT SEND IMAGE HERE
    /// </summary>
    [SerializeField]
    private Image SpeakerProfile;

    [Header("Speech Objects")]
    public GameObject SpeechObjects;
    public TextMeshProUGUI SpeechTextBox;

    [Header("InterrigationObjects")]
    [SerializeField]
    private GameObject InterrigationObjects;

    /// <summary>
    /// TextBox For NPC OptionSelected.
    /// </summary>
    [SerializeField]
    private TextMeshProUGUI InterrigationTextBox;

    /// <summary>
    ///  Leave me
    /// </summary>
    [SerializeField]
    private TextMeshProUGUI Option1;

    /// <summary>
    /// Leave me
    /// </summary>
    [SerializeField]
    private TextMeshProUGUI Option2;

    /// <summary>
    /// Leave me
    /// </summary>
    [SerializeField]
    private TextMeshProUGUI Option3;

    /// <summary>
    /// Summon me to screen
    /// </summary>
    public void Display()
    {
        if (this.gameObject.activeInHierarchy)        
            this.gameObject.SetActive(false);        
        else
            this.gameObject.SetActive(true);
    }
    /// <summary>
    /// switches dialog box mode from questioning to regular talking
    /// </summary>
    /// <param name="State">True for Interrogation false for regular speech</param>
    public void SwitchMode(bool State)
    {
        if (State)
        {

            InterrigationObjects.SetActive(true);
            SpeechObjects.SetActive(false);
        }
        else
        {
            InterrigationObjects.SetActive(false);
            SpeechObjects.SetActive(true);
        }
    }
    /// <summary>
    /// SelectOption for button pressed
    /// </summary>
    /// <param name="OptionSelected">The Component so we can get the text from it to compare.</param>
    public void SelectOption(TextMeshProUGUI OptionSelected)
    {
        _selectedOption = OptionSelected.text;
    }


}
