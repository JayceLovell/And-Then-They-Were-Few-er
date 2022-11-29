using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    [TextArea(15,20)]
    public string[] dialogueLines;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartDialogueSequence()
    {
        DialogueManager.dialogueManager.playableDirector.Pause();
        DialogueManager.dialogueManager.currentDialogue = dialogueLines;
        DialogueManager.dialogueManager.index = 0;
        DialogueManager.dialogueManager.OpenTextBox();
    }
}
