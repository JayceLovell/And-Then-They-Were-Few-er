using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static LightMachine;

public class LightMachine : Objects
{
    private bool Cycle;
    
   
    public Sprite Blue;
    public Sprite Orange;
    public Sprite Red;
    public Sprite Yellow;
    public Sprite Brown;


    public Animator Animator;
    public SpriteRenderer Renderer;

    protected override void Start()
    {
        base.Start();
        Cycle = false;

        Animator = GetComponent<Animator>();
        Renderer = GetComponent<SpriteRenderer>();
        Animator.SetBool("Cycle", Cycle);

    }

    protected override void SetUpDialogue()
    {
        base.SetUpDialogue();

        
        DialogueForObjects Dialogue0 = new DialogueForObjects();
        Dialogue0.JustAshlynTalking = true;
        Dialogue0.Text = "Hmm what kind of device is this?";

        DialogueForObject.Add(Dialogue0);

        DialogueForObjects Dialogue1 = new DialogueForObjects();
        Dialogue1.JustAshlynTalking = false;
        Dialogue1.Text = "What should I do?";
        Dialogue1.Option1 = new Options();
        Dialogue1.Option1.OptionSelectedInteger = 1;
        Dialogue1.Option1.NextElementNumber = 5;
        if (Cycle)
        {
            Dialogue1.Text = "Maybe I should turn this off";            
            Dialogue1.Option1.OptionText = "Turn Off";
        }
        else
        {           
            Dialogue1.Text = "Maybe I should turn this On";                    
            Dialogue1.Option1.OptionText = "Turn ON";
        }

        Dialogue1.Option2 = new Options();
        Dialogue1.Option2.OptionText = "Change Color.";
        Dialogue1.Option2.OptionSelectedInteger = 2;
        Dialogue1.Option2.NextElementNumber = 2;

        DialogueForObject.Add(Dialogue1);

        DialogueForObjects Dialogue2 = new DialogueForObjects();
        Dialogue2.JustAshlynTalking = false;
        Dialogue2.Text = "What color should I change it to?";

        Dialogue2.Option1 = new Options();
        Dialogue2.Option1.OptionSelectedInteger = 1;
        Dialogue2.Option1.OptionText = "Blue";
        Dialogue2.Option1.NextElementNumber = 5;

        Dialogue2.Option2 = new Options();
        Dialogue2.Option2.OptionSelectedInteger = 2;
        Dialogue2.Option2.OptionText = "Orange";
        Dialogue2.Option2.NextElementNumber = 5;

        Dialogue2.Option3 = new Options();
        Dialogue2.Option3.OptionSelectedInteger = 3;
        Dialogue2.Option3.OptionText = "More Colors";
        Dialogue2.Option3.NextElementNumber = 3;

        DialogueForObject.Add(Dialogue2);

        DialogueForObjects Dialogue3 = new DialogueForObjects();
        Dialogue3.JustAshlynTalking = false;
        Dialogue3.Text = "What color should I change it to?";

        Dialogue3.Option1 = new Options();
        Dialogue3.Option1.OptionSelectedInteger = 1;
        Dialogue3.Option1.OptionText = "Red";
        Dialogue3.Option1.NextElementNumber=5;

        Dialogue3.Option2 = new Options();
        Dialogue3.Option2.OptionSelectedInteger = 2;
        Dialogue3.Option2.OptionText = "Yellow";
        Dialogue3.Option2.NextElementNumber = 5;

        Dialogue3.Option3 = new Options();
        Dialogue3.Option3.OptionSelectedInteger = 3;
        Dialogue3.Option3.OptionText = "More Colors";
        Dialogue3.Option3.NextElementNumber = 4;

        DialogueForObject.Add(Dialogue3);

        DialogueForObjects Dialogue4 = new DialogueForObjects();
        Dialogue4.JustAshlynTalking = false;
        Dialogue4.Text = "What color should I change it to?";

        Dialogue4.Option1 = new Options();
        Dialogue4.Option1.OptionSelectedInteger = 1;
        Dialogue4.Option1.OptionText = "Brown";
        Dialogue4.Option1.NextElementNumber = 5;

        Dialogue4.Option2 = new Options();
        Dialogue4.Option2.OptionSelectedInteger = 2;
        Dialogue4.Option2.OptionText = "Back to beginning";
        Dialogue4.Option2.NextElementNumber = 1;
       

        DialogueForObject.Add(Dialogue4);


        DialogueForObjects Dialogue5 = new DialogueForObjects();
        Dialogue5.JustAshlynTalking = true;
        Dialogue5.EndInteraction = true;
        Dialogue5.Text = "Neat.";

        DialogueForObject.Add(Dialogue5);

    }

    public override void Use()
    {
        base.Use();
    }

    public override void OptionSelected(int OptionSelected)
    {
        int TempIndex = _index;
        //first check how far we are in the dialogue
        switch (_index)
        {
            case 2:
                // All Options will start with 1
                switch (OptionSelected)
                {
                    case 1:
                        if (Cycle)
                            Cycle = false;
                        else
                        {
                            Animator.enabled = true;
                            Cycle = true;
                        }

                        Animator.SetBool("Cycle", Cycle);

                        TempIndex = DialogueForObject[_index-1].Option1.NextElementNumber;                        
                        break;
                    case 2:
                        TempIndex = DialogueForObject[_index-1].Option2.NextElementNumber;                        
                        break;                      
                }
                break;
            case 3:
                Animator.enabled = false;
                switch (OptionSelected)
                {
                    case 1:                        
                        Renderer.sprite = Blue;
                        TempIndex = DialogueForObject[_index - 1].Option1.NextElementNumber;                        
                       break;
                    case 2:                        
                        Renderer.sprite = Orange;
                        TempIndex = DialogueForObject[_index - 1].Option2.NextElementNumber;                        
                        break;
                    case 3:
                        TempIndex = DialogueForObject[_index - 1].Option3.NextElementNumber;                        
                        break;
                }
                break;
            case 4:
                Animator.enabled = false;
                switch (OptionSelected)
                {
                    case 1:
                        Renderer.sprite = Red;
                        TempIndex = DialogueForObject[_index - 1].Option1.NextElementNumber;                                              
                    break;
                    case 2:
                        Renderer.sprite = Yellow;
                        TempIndex = DialogueForObject[_index - 1].Option2.NextElementNumber;                        
                        break;
                    case 3:
                        TempIndex = DialogueForObject[_index - 1].Option3.NextElementNumber;                        
                        break;
                }
                break;
            case 5:
                Animator.enabled = false;
                switch (OptionSelected)
                {
                    case 1:
                        Renderer.sprite = Brown;
                        TempIndex = DialogueForObject[_index - 1].Option1.NextElementNumber;                        
                        break;
                    case 2:
                        TempIndex = DialogueForObject[_index - 1].Option2.NextElementNumber;                        
                        break;
                }
                break;
        }
        _index = TempIndex;
        Use();
    }
}
