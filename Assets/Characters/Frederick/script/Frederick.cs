using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Frederick : Character
{
    //Regular
    //DialogRegularConvo ExampleRegularConvo = new DialogRegularConvo();
    //ExampleRegularConvo.Text = "Example";
    //ExampleRegularConvo.NPCTalking = true;
    //dialogForRegularConvo.Add(ExampleRegularConvo);

    public override void SetRegularConvo()
    {
        base.SetRegularConvo();
        if (GameManager.Instance.CurrentGameProgress <= 3)
        {
            DialogRegularConvo ExampleForBeforeMurder = new DialogRegularConvo();
            ExampleForBeforeMurder.NPCTalking = true;
            ExampleForBeforeMurder.Text = "(The corrupt mayor of the town)";
            dialogForRegularConvo.Add(ExampleForBeforeMurder);

            DialogRegularConvo ExampleForBeforeMurder1 = new DialogRegularConvo();
            ExampleForBeforeMurder1.NPCTalking = false;
            ExampleForBeforeMurder1.Text = "Good Evening Mayor";
            dialogForRegularConvo.Add(ExampleForBeforeMurder1);

            DialogRegularConvo ExampleForBeforeMurder2 = new DialogRegularConvo();
            ExampleForBeforeMurder2.NPCTalking = true;
            ExampleForBeforeMurder2.Text = "Good Evening Ms. Hunt";
            dialogForRegularConvo.Add(ExampleForBeforeMurder2);

        }
        else
        {

            DialogRegularConvo ExampleForAfterMurder = new DialogRegularConvo();
            ExampleForAfterMurder.NPCTalking = true;
            ExampleForAfterMurder.Text = "Such a tragedy... How shall I ever explain this to the press?";
            dialogForRegularConvo.Add(ExampleForAfterMurder);
        }
    }
    public override void SetInterrogationConvo()
    {

        base.SetInterrogationConvo();

        DialogueForInterrogation ExampleInterrogationConvo = new DialogueForInterrogation();
        ExampleInterrogationConvo.NextElementNumber = 1;
        ExampleInterrogationConvo.NPCTalking = false;
        ExampleInterrogationConvo.EndInterrogation = false;
        ExampleInterrogationConvo.NoQuestions = false;
        ExampleInterrogationConvo.Response = " ";
        //Creating Questions

        ExampleInterrogationConvo.Question1 = new Question();
        ExampleInterrogationConvo.Question1.QuestionText = "Where were you at the time of the murder?";
        ExampleInterrogationConvo.Question1.NextElementNumber = 1;

        ExampleInterrogationConvo.Question2 = new Question();
        ExampleInterrogationConvo.Question2.QuestionText = " ";
        ExampleInterrogationConvo.Question2.NextElementNumber = 0;

        ExampleInterrogationConvo.Question3 = new Question();
        ExampleInterrogationConvo.Question3.QuestionText = " ";
        ExampleInterrogationConvo.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo);

        //Element 1

        DialogueForInterrogation ExampleInterrogationConvo1 = new DialogueForInterrogation();
        ExampleInterrogationConvo1.NextElementNumber = 1;
        ExampleInterrogationConvo1.NPCTalking = false;
        ExampleInterrogationConvo1.EndInterrogation = false;
        ExampleInterrogationConvo1.NoQuestions = false;
        ExampleInterrogationConvo1.Response = "I was in [some room near the lab]. " +
            "I heard a loud noise, and went out into the hall to investigate. I walked by the lab, but the door was closed at the time.";
        //Creating a Question

        ExampleInterrogationConvo1.Question1 = new Question();
        ExampleInterrogationConvo1.Question1.QuestionText = "A loud noise? What do you think it was?";
        ExampleInterrogationConvo1.Question1.NextElementNumber = 2;

        ExampleInterrogationConvo1.Question2 = new Question();
        ExampleInterrogationConvo1.Question2.QuestionText = "Did you see anyone else while you were out in the hall?";
        ExampleInterrogationConvo1.Question2.NextElementNumber = 3;

        ExampleInterrogationConvo1.Question3 = new Question();
        ExampleInterrogationConvo1.Question3.QuestionText = "The door was closed? That's interesting, it was ajar when I discovered Nikki ";
        ExampleInterrogationConvo1.Question3.NextElementNumber = 4;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo1);

        //Element 2

        DialogueForInterrogation ExampleInterrogationConvo2 = new DialogueForInterrogation();
        ExampleInterrogationConvo2.NextElementNumber = 1;
        ExampleInterrogationConvo2.NPCTalking = false;
        ExampleInterrogationConvo2.EndInterrogation = false;
        ExampleInterrogationConvo2.NoQuestions = false;
        ExampleInterrogationConvo2.Response = "I had thought it might be thunder.";
        //Creating a Question

        ExampleInterrogationConvo2.Question1 = new Question();
        ExampleInterrogationConvo2.Question1.QuestionText = "Interesting";
        ExampleInterrogationConvo2.Question1.NextElementNumber = 0;

        ExampleInterrogationConvo2.Question2 = new Question();
        ExampleInterrogationConvo2.Question2.QuestionText = " ";
        ExampleInterrogationConvo2.Question2.NextElementNumber = 0;

        ExampleInterrogationConvo2.Question3 = new Question();
        ExampleInterrogationConvo2.Question3.QuestionText = " ";
        ExampleInterrogationConvo2.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo2);

        //Element 3

        DialogueForInterrogation ExampleInterrogationConvo3 = new DialogueForInterrogation();
        ExampleInterrogationConvo3.NextElementNumber = 1;
        ExampleInterrogationConvo3.NPCTalking = false;
        ExampleInterrogationConvo3.EndInterrogation = false;
        ExampleInterrogationConvo3.NoQuestions = false;
        ExampleInterrogationConvo3.Response = "I did see Mirianne, but she was a bit further down the hall and walking away from the lab.";
        //Creating a Question

        ExampleInterrogationConvo3.Question1 = new Question();
        ExampleInterrogationConvo3.Question1.QuestionText = "Very interesting";
        ExampleInterrogationConvo3.Question1.NextElementNumber = 0;

        ExampleInterrogationConvo3.Question2 = new Question();
        ExampleInterrogationConvo3.Question2.QuestionText = " ";
        ExampleInterrogationConvo3.Question2.NextElementNumber = 0;

        ExampleInterrogationConvo3.Question3 = new Question();
        ExampleInterrogationConvo3.Question3.QuestionText = " ";
        ExampleInterrogationConvo3.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo3);

        //Element 4

        DialogueForInterrogation ExampleInterrogationConvo4 = new DialogueForInterrogation();
        ExampleInterrogationConvo4.NextElementNumber = 1;
        ExampleInterrogationConvo4.NPCTalking = false;
        ExampleInterrogationConvo4.EndInterrogation = false;
        ExampleInterrogationConvo4.NoQuestions = false;
        ExampleInterrogationConvo4.Response = "Strange... And the keys to the room were not inside when you discovered the body?";
        //Creating a Question

        ExampleInterrogationConvo4.Question1 = new Question();
        ExampleInterrogationConvo4.Question1.QuestionText = "They were not";
        ExampleInterrogationConvo4.Question1.NextElementNumber = 5;

        ExampleInterrogationConvo4.Question2 = new Question();
        ExampleInterrogationConvo4.Question2.QuestionText = " ";
        ExampleInterrogationConvo4.Question2.NextElementNumber = 0;

        ExampleInterrogationConvo4.Question3 = new Question();
        ExampleInterrogationConvo4.Question3.QuestionText = " ";
        ExampleInterrogationConvo4.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo4);

        //Element 5

        DialogueForInterrogation ExampleInterrogationConvo5 = new DialogueForInterrogation();
        ExampleInterrogationConvo5.NextElementNumber = 1;
        ExampleInterrogationConvo5.NPCTalking = false;
        ExampleInterrogationConvo5.EndInterrogation = true;
        ExampleInterrogationConvo5.NoQuestions = false;
        ExampleInterrogationConvo5.Response = "It might do us some good to look for them";
        //Creating a Question

        ExampleInterrogationConvo5.Question1 = new Question();
        ExampleInterrogationConvo5.Question1.QuestionText = "Indeed";
        ExampleInterrogationConvo5.Question1.NextElementNumber = 0;

        ExampleInterrogationConvo5.Question2 = new Question();
        ExampleInterrogationConvo5.Question2.QuestionText = " ";
        ExampleInterrogationConvo5.Question2.NextElementNumber = 0;

        ExampleInterrogationConvo5.Question3 = new Question();
        ExampleInterrogationConvo5.Question3.QuestionText = " ";
        ExampleInterrogationConvo5.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo5);
    }

    public override void SetAfterClueConvo()
    {
        base.SetAfterClueConvo();
        DialogueAfterClue ExampledialogueAfterClue = new DialogueAfterClue();
        ExampledialogueAfterClue.CorrectClue = false;
        ExampledialogueAfterClue.EndInterrogation = true;
        ExampledialogueAfterClue.NoQuestions = true;
        ExampledialogueAfterClue.NPCTalking = true;
        ExampledialogueAfterClue.Response = " I don't know what that is ";
        DialogueAfterClues.Add(ExampledialogueAfterClue);

        DialogueAfterClue ExampledialogueAfterClue1 = new DialogueAfterClue();
        ExampledialogueAfterClue1.CorrectClue = true;
        ExampledialogueAfterClue1.EndInterrogation = false;
        ExampledialogueAfterClue1.NoQuestions = true;
        ExampledialogueAfterClue1.NPCTalking = true;
        ExampledialogueAfterClue1.Response = " *looks nervous* ";
        DialogueAfterClues.Add(ExampledialogueAfterClue1);

    }
}

/* 
 Potential Dialogue  

---------
*/
