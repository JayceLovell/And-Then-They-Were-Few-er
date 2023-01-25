using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public bool interrogationDialogue;

    public Clue correctClue;

    //regular lines
    [TextArea(15,20)]
    public List<string> dialogueLines;

    //lines that play after you present the npc with the right clue
    [TextArea(15, 20)]
    public List<string> dialogueAfterClue;

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
        DialogueManager.dialogueManager.currentDialogueScript = this;

        if (interrogationDialogue)
        {
            DialogueManager.dialogueManager.inInterrogation = true;

            if (correctClue)
            {
                DialogueManager.dialogueManager.currentCorrectClue = correctClue;
            }
        }
        DialogueManager.dialogueManager.playableDirector.Pause();
        DialogueManager.dialogueManager.currentDialogue = dialogueLines;
        DialogueManager.dialogueManager.index = 0;
        DialogueManager.dialogueManager.OpenTextBox();
    }

    //to be called when the player presents the person being interrogated with the right clue
    public void StartPostClueDialogue()
    {
        //DialogueManager.dialogueManager.CloseTextBox();
        DialogueManager.dialogueManager.inDialogue = true;
        DialogueManager.dialogueManager.inInterrogation = true;
        //DialogueManager.dialogueManager.currentDialogue.RemoveRange(0, DialogueManager.dialogueManager.currentDialogue.Count);
        DialogueManager.dialogueManager.currentDialogue = dialogueAfterClue;
        DialogueManager.dialogueManager.index = 0;
        DialogueManager.dialogueManager.OpenTextBox();
    }
}
