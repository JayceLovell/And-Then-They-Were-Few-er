using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueObjectController : MonoBehaviour
{
    private bool _isInterrigation;
    private string _text;
    private string _speakerName;
    private Sprite _speakerImage;

    /// <summary>
    /// When bool is set.
    /// Activate Object and setup.
    /// </summary>
    public bool InterrigationMode
    {
        get { return _isInterrigation; }
        set { 
            _isInterrigation = value;

            if (InterrigationMode)
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
            if(this.gameObject.active==false)
                this.gameObject.SetActive(true);

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
    /// <summary>
    /// Send Name here
    /// </summary>
    public string SpeakerName
    {
        get { 
            return _speakerName; 
        }
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
        get { 
            return _speakerImage;
        }
        set
        {
            _speakerImage = value;
            SpeakerProfile.sprite = value;
        }
    }
    /// <summary>
    /// DO NOT SEND NAME HERE
    /// </summary>
    public TextMeshProUGUI SpeakerLabel;
    /// <summary>
    /// DO NOT SEND IMAGE HERE
    /// </summary>
    public SpriteRenderer SpeakerProfile;

    [Header("Speech Objects")]
    public GameObject SpeechObjects;
    public TextMeshProUGUI SpeechTextBox;

    [Header("InterrigationObjects")]
    public GameObject InterrigationObjects;
    public TextMeshProUGUI InterrigationTextBox;

    /// <summary>
    /// Summon me to screen
    /// </summary>
    public void Display()
    {
        if (this.gameObject.active)        
            this.gameObject.SetActive(false);        
        else
            this.gameObject.SetActive(true);
    }
}
