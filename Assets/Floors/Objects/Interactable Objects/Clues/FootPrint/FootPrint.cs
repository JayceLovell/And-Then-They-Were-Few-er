using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootPrint : Clues
{
	protected override void SetUpDialogue()
    {
		//Resending
        base.SetUpDialogue();

        DialogueForObjects ExampleForDialogueForObject = new DialogueForObjects();
        ExampleForDialogueForObject.JustAshlynTalking = true;
        ExampleForDialogueForObject.EndInteraction = true;
        ExampleForDialogueForObject.Text = "Hm, footprints...";

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
