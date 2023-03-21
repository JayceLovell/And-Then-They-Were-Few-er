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
        Dialogue1.Text = "Hmmm, this clock clearly isn't working.";

        DialogueForObject.Add(Dialogue1);

        DialogueForObjects Dialogue2 = new DialogueForObjects();
        Dialogue2.JustAshlynTalking = true;
        Dialogue2.EndInteraction = false;
        Dialogue2.Text = "Even though it looks functional, something's... off";

        DialogueForObject.Add(Dialogue2);

        DialogueForObjects Dialogue3 = new DialogueForObjects();
        Dialogue3.JustAshlynTalking = true;
        Dialogue3.EndInteraction = false;
        Dialogue3.Text = "It just doesn't have enough notches.";

        DialogueForObject.Add(Dialogue3);

        DialogueForObjects Dialogue4 = new DialogueForObjects();
        Dialogue4.JustAshlynTalking = true;
        Dialogue4.EndInteraction = true;
        Dialogue4.Text = "Who built this? It definitely wasn't Nikki...";

        DialogueForObject.Add(Dialogue4);
    }
}
