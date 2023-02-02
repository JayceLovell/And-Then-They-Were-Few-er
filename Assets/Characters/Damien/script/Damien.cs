using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damien : Character
{

    void Start()
    {
        base.Start();
        /*
        //Regular
        DialogRegularConvo ExampleRegularConvo = new DialogRegularConvo();
        ExampleRegularConvo.Text = "Example";
        ExampleRegularConvo.NPCTalking = true;
        dialogForRegularConvo.Add(ExampleRegularConvo);*/

        //Interrogation
        DialogueForInterrogation ExampleInterrogationConvo = new DialogueForInterrogation();
        ExampleInterrogationConvo.NextElementNumber = 1;
        ExampleInterrogationConvo.PlayerTalk = false;
        ExampleInterrogationConvo.EndInterrogation = false;
        ExampleInterrogationConvo.NoQuestions = false;
        ExampleInterrogationConvo.Response = "Example Response";
        //Creating a Question
        ExampleInterrogationConvo.Question1.QuestionText = "First Question";
        ExampleInterrogationConvo.Question1.NextElementNumber = 2;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo);
    }
}

/*
 
*/