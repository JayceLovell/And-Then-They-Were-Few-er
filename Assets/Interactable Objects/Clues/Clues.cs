using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clues : Objects
{

    protected override void Start()
    {
        base.Start();       
    }
    protected override void SetUpDialogue()
    {
        base.SetUpDialogue();
    }
    public override void Use()
    {
        base.Use();

        SoundManager.PlaySound(SoundManager.SoundFX.Clue);
        
        ClueStatement.ClueText = ClueStatementText;
        ClueStatement.PickedUp = true;
    }   
    public override void OptionSelected(int index)
    {
        base.OptionSelected(index);
    }
}
