using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronPipe : Clues
{
	protected override void SetUpDialogue()
    {
        base.SetUpDialogue();

        DialogueForObjects ExampleForDialogueForObject = new DialogueForObjects();
        ExampleForDialogueForObject.JustAshlynTalking = true;
        ExampleForDialogueForObject.EndInteraction = true;
        ExampleForDialogueForObject.Text = "Now what's this pipe doing here...?";

        DialogueForObject.Add(ExampleForDialogueForObject);
    }
    public override void Use()
    {
        base.Use();
    }
    public override void OptionSelected(int index)
    {
        base.OptionSelected(index);
    }
}
