using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public bool interrogationDialogue;

    //doesn't do anything right now
    public Clue correctClue;

    [TextArea(15,20)]
    public string[] dialogueLines;

    [TextArea(15, 20)]
    public string[] postInterrogationDialogueLines;

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
        if (interrogationDialogue)
        {
            DialogueManager.dialogueManager.inInterrogation = true;
        }
        DialogueManager.dialogueManager.playableDirector.Pause();
        DialogueManager.dialogueManager.currentDialogue = dialogueLines;
        DialogueManager.dialogueManager.index = 0;
        DialogueManager.dialogueManager.OpenTextBox();
    }

    //to be called when the player presents the person being interrogated with the right clue
    public void StartPostInterrogation()
    {
        DialogueManager.dialogueManager.CloseTextBox();
        DialogueManager.dialogueManager.currentDialogue = postInterrogationDialogueLines;
        DialogueManager.dialogueManager.index = 0;
        DialogueManager.dialogueManager.OpenTextBox();
    }
}
