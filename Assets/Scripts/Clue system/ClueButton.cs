using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClueButton : MonoBehaviour
{
    public ClueManager clueManager;
    public Clue clue;

    public TextMeshProUGUI text;

    private void Start()
    {
        text.text = clue.clueText;
    }

    public void OnClick()
    {
        
    }
}
