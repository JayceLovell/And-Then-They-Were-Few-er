using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
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
    /// <summary>
    /// DO NOT SEND NAME HERE
    /// </summary>
    [Header("Who is talking?")]
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

    public Clue currentClue;

    public static DialogueObjectController dialogueObjectController;

    private void Awake()
    {
        dialogueObjectController = this;
    }

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
        Text = "";
        if (State)
        {
            InterrigationObjects.SetActive(true);
            SpeechObjects.SetActive(false);
            if (GameManager.Instance.CurrentScene == "InterrogationScene")
                EventSystem.current.firstSelectedGameObject = GameObject.Find("BackButton");
            else
                EventSystem.current.SetSelectedGameObject(GameObject.Find("Question 1"));
                //EventSystem.current.firstSelectedGameObject = GameObject.Find("Question 1");
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
    /// <param name="End">True for when this option ends interrogation</param>
    public void SetUpQuestions(int QuestionNumber, string QuestionText, int WhereQuestionGoing,bool End)
    {
        switch (QuestionNumber)
        {
            case 1:
                Question1= QuestionText;
                QuestionButton1.onClick.RemoveAllListeners();
                if (End)
                    QuestionButton1.onClick.AddListener(()=>_interrogationController.OnQuit());
                else
                    QuestionButton1.onClick.AddListener(()=>_interrogationController.NextElementForInterrogating= WhereQuestionGoing);
                break;
            case 2:
                Question2= QuestionText;
                QuestionButton2.onClick.RemoveAllListeners();
                if (End)
                    QuestionButton2.onClick.AddListener(() => _interrogationController.OnQuit());
                else
                    QuestionButton2.onClick.AddListener(()=>_interrogationController.NextElementForInterrogating= WhereQuestionGoing);
                break;
            case 3:            
                Question3= QuestionText;
                QuestionButton3.onClick.RemoveAllListeners();
                if (End)
                    QuestionButton3.onClick.AddListener(() => _interrogationController.OnQuit());
                else
                    QuestionButton3.onClick.AddListener(()=>_interrogationController.NextElementForInterrogating= WhereQuestionGoing);
                break;
            default:
                Debug.LogError("Questioning out of bounds");
                break;
        }
    }
    /// <summary>
    /// SettingUp options for talking to objects
    /// </summary>
    /// <param name="OptionNumber">Number of option to return back to interactble object for selected option</param>
    /// <param name="OptionText">Text to Display</param>
    /// <param name="IntereactbleOject">The object that the player is interacting with for this option just put "this.gameobject;".</param>
    public void SetUpQuestions(int OptionNumber,string OptionText,GameObject IntereactbleOject)
    {
        switch(OptionNumber)
        {
            case 1:
                Question1 = OptionText;
                QuestionButton1.onClick.RemoveAllListeners();
                QuestionButton1.onClick.AddListener(() => GetObjectScript(IntereactbleOject).GetType().GetMethod("OptionSelected").Invoke(GetObjectScript(IntereactbleOject),new object[] { OptionNumber }));
                QuestionButton1.interactable = true;
                break;
            case 2:
                Question2 = OptionText;
                QuestionButton2.onClick.RemoveAllListeners();
                QuestionButton2.onClick.AddListener(() => GetObjectScript(IntereactbleOject).GetType().GetMethod("OptionSelected").Invoke(GetObjectScript(IntereactbleOject),new object[] { OptionNumber }));
                QuestionButton2.interactable = true;
                break;
            case 3:
                Question3 = OptionText;
                QuestionButton3.onClick.RemoveAllListeners();
                QuestionButton3.onClick.AddListener(() => GetObjectScript(IntereactbleOject).GetType().GetMethod("OptionSelected").Invoke(GetObjectScript(IntereactbleOject), new object[] { OptionNumber }));
                QuestionButton3.interactable = true;
                break;
            default:
                Debug.LogError("Option out of bounds");
                break;
        }
    }
    /// <summary>
    /// NoOption
    /// </summary>
    public void SetUpQuestions(int OptionNumber,string OptionText)
    {
        switch (OptionNumber)
        {
            case 1:
                Question1 = OptionText;
                QuestionButton1.interactable = false;
                break;
            case 2:
                Question2 = OptionText;
                QuestionButton2.interactable = false;
                break;
            case 3:
                Question3 = OptionText;
                QuestionButton3.interactable = false;
                break;
        }
    }

    private Component GetObjectScript(GameObject Object)
    {
        Component ObjectScript = null;

        Component[] components =Object.GetComponents(typeof(Component));
        foreach (Component component in components)
        {
            if (component.GetType().Name == Object.name)
            {
                ObjectScript = component;
                break;
            }
        }

        return ObjectScript;
    }

}
