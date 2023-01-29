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

    /// <summary>
    /// When bool is set.
    /// SetUpObject for mode.
    /// </summary>
    public bool InterrigationMode
    {
        get { return _isInterrigation; }
        set { 
            _isInterrigation = value;
            Display(true);
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
            _text = value;
            if (InterrigationTextBox.IsActive())
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
            QuestionText1.text = _question1;
        }
    }
    public string Question2
    {
        set
        {
            _question2 = value;
            QuestionText2.text = _question2;
        }
    }
    public string Question3
    {
        set
        {
            _question3 = value;
            QuestionText3.text = _question3;
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

    [SerializeField]
    private TextMeshProUGUI QuestionText1;
    [SerializeField]
    private Button QuestionButton1;


    [SerializeField]
    private TextMeshProUGUI QuestionText2;
    [SerializeField]
    private Button QuestionButton2;


    [SerializeField]
    private TextMeshProUGUI QuestionText3;
    [SerializeField]
    private Button QuestionButton3;

    /// <summary>
    /// Summon me to screen
    /// </summary>
    public void Display(bool State)
    {
         this.gameObject.SetActive(State);
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
    /// Set Up the questions for Dialogue Box
    /// </summary>
    /// <param name="QuestionNumber">the number Question Example 1,2 or 3</param>
    /// <param name="QuestionText">The String to fill the Question with</param>
    /// <param name="WhereQuestionGoing">Which element this question goes to.</param>
    public void SetUpQuestions(int QuestionNumber, string QuestionText, int WhereQuestionGoing)
    {
        switch (QuestionNumber)
        {
            case 1:
                Question1= QuestionText;
                QuestionButton1.onClick.AddListener(()=>_interrogationController.NextElementForInterrogating= WhereQuestionGoing);
                break;
            case 2:
                Question2= QuestionText;
                QuestionButton2.onClick.AddListener(()=>_interrogationController.NextElementForInterrogating= WhereQuestionGoing);
                break;
            case 3:            
                Question3= QuestionText;
                QuestionButton3.onClick.AddListener(()=>_interrogationController.NextElementForInterrogating= WhereQuestionGoing);
                break;
            default:
                Debug.LogError("Questioning out of bounds");
                break;
        }
    }


}
