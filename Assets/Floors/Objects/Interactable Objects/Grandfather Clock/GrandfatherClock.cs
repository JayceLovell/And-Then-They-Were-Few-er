using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrandfatherClock : Objects
{
    private Animator _animator;
    protected override void Start()
    {
        base.Start();
        _animator = GetComponent<Animator>();
    }

    protected override void SetUpDialogue()
    {
        base.SetUpDialogue();

        DialogueForObjects Dialogue1 = new DialogueForObjects();
        Dialogue1.JustAshlynTalking = true;
        Dialogue1.EndInteraction = false;
        Dialogue1.Text = "Hmmm this clock clearly isn't working.";

        DialogueForObject.Add(Dialogue1);

        DialogueForObjects Dialogue2 = new DialogueForObjects();
        Dialogue2.JustAshlynTalking = true;
        Dialogue2.EndInteraction = false;
        Dialogue2.Text = "Even if it did the design.";

        DialogueForObject.Add(Dialogue2);

        DialogueForObjects Dialogue3 = new DialogueForObjects();
        Dialogue3.JustAshlynTalking = true;
        Dialogue3.EndInteraction = false;
        Dialogue3.Text = "It doesn't have enough notches";

        DialogueForObject.Add(Dialogue3);

        DialogueForObjects Dialogue4 = new DialogueForObjects();
        Dialogue4.JustAshlynTalking = true;
        Dialogue4.EndInteraction = true;
        Dialogue4.Text = "Who made this?";

        DialogueForObject.Add(Dialogue4);
    }
}
