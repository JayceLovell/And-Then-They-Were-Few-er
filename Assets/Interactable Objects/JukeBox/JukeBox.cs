using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static Objects;

public class JukeBox : Objects
{
    public Animator _playingAnimation;
    protected override void Start()
    {
        base.Start();
        _playingAnimation = GetComponent<Animator>();
        _playingAnimation.SetBool("Playing", true);
    }

    protected override void SetUpDialogue()
    {
        base.SetUpDialogue();        
        
        DialogueForObjects ExampleForDialogueForObject = new DialogueForObjects();
        ExampleForDialogueForObject.JustAshlynTalking = true;
        ExampleForDialogueForObject.EndInteraction = false;
        ExampleForDialogueForObject.Text = "The JukeBox is playing a lovelly melody.";

        DialogueForObject.Add(ExampleForDialogueForObject);

        DialogueForObjects ExampleForDialogueForObject1 = new DialogueForObjects();
        ExampleForDialogueForObject1.JustAshlynTalking = false;
        ExampleForDialogueForObject.EndInteraction = false;
        ExampleForDialogueForObject1.Text = "What should i do to it?";

        //Add option1
        ExampleForDialogueForObject1.Option1 = new Options();
        ExampleForDialogueForObject1.Option1.OptionSelectedInteger = 1;
        ExampleForDialogueForObject1.Option1.OptionText = "Turn Off Music";
        ExampleForDialogueForObject1.Option1.NextElementNumber = 2;

        //Add option2
        ExampleForDialogueForObject1.Option2 = new Options();
        ExampleForDialogueForObject1.Option2.OptionSelectedInteger = 2;
        ExampleForDialogueForObject1.Option2.OptionText = "Select different music";
        /// Adnan i havn't finish this one

        DialogueForObject.Add(ExampleForDialogueForObject1);

        DialogueForObjects ExampleForDialogueForObject3 = new DialogueForObjects();
        ExampleForDialogueForObject3.JustAshlynTalking = true;
        ExampleForDialogueForObject3.EndInteraction = true;
        ExampleForDialogueForObject3.Text = "Well thats the end of that.";

        DialogueForObject.Add(ExampleForDialogueForObject3);
    }

    public override void Use()
    {
        base.Use();        
    }

    public override void OptionSelected(int index)
    {

        //first check how far we are in the dialogue
        switch (_index)
        {            
            case 2:
                // All Options will start with 1
                switch (index)
                {
                    case 1:
                        GameObject.Find("BgSound").GetComponent<SoundBGVolume>().PauseMusic();                       
                        _index = DialogueForObject[_index-1].Option1.NextElementNumber;
                        InDialog = false;
                        Use();
                        break;
                }    
                break;
        }

    }

}

