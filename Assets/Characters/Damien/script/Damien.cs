using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Damien : Character
{
    //Regular
    //DialogRegularConvo ExampleRegularConvo = new DialogRegularConvo();
    //ExampleRegularConvo.Text = "Example";
    //ExampleRegularConvo.NPCTalking = true;
    //dialogForRegularConvo.Add(ExampleRegularConvo);
    public override void SetRegularConvo()
    {
        base.SetRegularConvo();
        // Create convo before Murder
        if (GameManager.Instance.CurrentGameProgress <= 3)
        {

            DialogRegularConvo ExampleForBeforeMurder = new DialogRegularConvo();
            ExampleForBeforeMurder.NPCTalking = true;
            ExampleForBeforeMurder.Text = "(The young apprentice of Nikki Test)";
            dialogForRegularConvo.Add(ExampleForBeforeMurder);

            DialogRegularConvo ExampleForBeforeMurder1 = new DialogRegularConvo();
            ExampleForBeforeMurder1.NPCTalking = true;
            ExampleForBeforeMurder1.Text = "Ah, you must be Detective Ashlyn. Nikki has told me so much about you.";
            dialogForRegularConvo.Add(ExampleForBeforeMurder1);

            DialogRegularConvo ExampleForBeforeMurder2 = new DialogRegularConvo();
            ExampleForBeforeMurder2.NPCTalking = false;
            ExampleForBeforeMurder2.Text = " She has? So I would assume you're Nikki's apprentice then?";
            dialogForRegularConvo.Add(ExampleForBeforeMurder2);

            DialogRegularConvo ExampleForBeforeMurder3 = new DialogRegularConvo();
            ExampleForBeforeMurder3.NPCTalking = true;
            ExampleForBeforeMurder3.Text = " Oh, pardon me I forgot to introduce myself. I am Damien and yes I am Nikki's apprentice.";
            dialogForRegularConvo.Add(ExampleForBeforeMurder3);

            DialogRegularConvo ExampleForBeforeMurder4 = new DialogRegularConvo();
            ExampleForBeforeMurder4.NPCTalking = true;
            ExampleForBeforeMurder4.Text = " Nikki was so excited to finally meet you again, so please make yourself at home.";
            dialogForRegularConvo.Add(ExampleForBeforeMurder4);

            DialogRegularConvo ExampleForBeforeMurder5 = new DialogRegularConvo();
            ExampleForBeforeMurder5.NPCTalking = false;
            ExampleForBeforeMurder5.Text = "(Ashlyn begins to blush a little)";
            dialogForRegularConvo.Add(ExampleForBeforeMurder5);

            DialogRegularConvo ExampleForBeforeMurder6 = new DialogRegularConvo();
            ExampleForBeforeMurder6.NPCTalking = false;
            ExampleForBeforeMurder6.Text = "I'm surprised Nikki still cares about me that much considering it's been years since we last talked.";
            dialogForRegularConvo.Add(ExampleForBeforeMurder6);

            DialogRegularConvo ExampleForBeforeMurder7 = new DialogRegularConvo();
            ExampleForBeforeMurder7.NPCTalking = true;
            ExampleForBeforeMurder7.Text = "Of course Nikki still cares. To tell the truth she's been wanting to meet with you again for a while now but has been far too busy to reach out until now.";
            dialogForRegularConvo.Add(ExampleForBeforeMurder7);

            DialogRegularConvo ExampleForBeforeMurder8 = new DialogRegularConvo();
            ExampleForBeforeMurder8.NPCTalking = false;
            ExampleForBeforeMurder8.Text = " Whoa... I guess it isn't easy being an inventor.";
            dialogForRegularConvo.Add(ExampleForBeforeMurder8);

            DialogRegularConvo ExampleForBeforeMurder9 = new DialogRegularConvo();
            ExampleForBeforeMurder9.NPCTalking = true;
            ExampleForBeforeMurder9.Text = " Sadly it isn't but that's what makes today quite special.";
            dialogForRegularConvo.Add(ExampleForBeforeMurder9);

            DialogRegularConvo ExampleForBeforeMurder10 = new DialogRegularConvo();
            ExampleForBeforeMurder10.NPCTalking = true;
            ExampleForBeforeMurder10.Text = "She arranged this whole event so we could celebrate her achievements and have a good time.";
            dialogForRegularConvo.Add(ExampleForBeforeMurder10);

            DialogRegularConvo ExampleForBeforeMurder11 = new DialogRegularConvo();
            ExampleForBeforeMurder11.NPCTalking = true;
            ExampleForBeforeMurder11.Text = "So please enjoy the food and drink and relax.";
            dialogForRegularConvo.Add(ExampleForBeforeMurder11);

            DialogRegularConvo ExampleForBeforeMurder12 = new DialogRegularConvo();
            ExampleForBeforeMurder12.NPCTalking = false;
            ExampleForBeforeMurder12.Text = "Haha, yeah will do.";
            dialogForRegularConvo.Add(ExampleForBeforeMurder12);
        }
        else
        {
            // Create convo after Murder
            DialogRegularConvo ExampleForAfterMurder = new DialogRegularConvo();
            ExampleForAfterMurder.NPCTalking = true;
            ExampleForAfterMurder.Text = "Poor Nikki";
            dialogForRegularConvo.Add(ExampleForAfterMurder);
        }
    }
    public override void SetInterrogationConvo()
    {
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
        ExampleInterrogationConvo.Question2.QuestionText = "Do you know where Watson is?";
        ExampleInterrogationConvo.Question2.NextElementNumber = 5;

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
        ExampleInterrogationConvo1.Response = "I was in the study.";
        //Creating a Question

        ExampleInterrogationConvo1.Question1 = new Question();
        ExampleInterrogationConvo1.Question1.QuestionText = "Is there anyone that can verify this? ";
        ExampleInterrogationConvo1.Question1.NextElementNumber = 2;

        ExampleInterrogationConvo1.Question2 = new Question();
        ExampleInterrogationConvo1.Question2.QuestionText = " ";
        ExampleInterrogationConvo1.Question2.NextElementNumber = 0;

        ExampleInterrogationConvo1.Question3 = new Question();
        ExampleInterrogationConvo1.Question3.QuestionText = " ";
        ExampleInterrogationConvo1.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo1);

        //Element 2

        DialogueForInterrogation ExampleInterrogationConvo2 = new DialogueForInterrogation();
        ExampleInterrogationConvo2.NextElementNumber = 1;
        ExampleInterrogationConvo2.NPCTalking = false;
        ExampleInterrogationConvo2.EndInterrogation = false;
        ExampleInterrogationConvo2.NoQuestions = false;
        ExampleInterrogationConvo2.Response = "Yes, Karol was with me";
        //Creating a Question

        ExampleInterrogationConvo2.Question1 = new Question();
        ExampleInterrogationConvo2.Question1.QuestionText = "Really? And why were you two together?";
        ExampleInterrogationConvo2.Question1.NextElementNumber = 3;

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
        ExampleInterrogationConvo3.Response = "*Damien stutters*... Umm, we had struck up a conversation about Nikki's synthesizer.";
        //Creating a Question

        ExampleInterrogationConvo3.Question1 = new Question();
        ExampleInterrogationConvo3.Question1.QuestionText = "Hm, you would discuss your mentor's latest invention with her biggest rival?";
        ExampleInterrogationConvo3.Question1.NextElementNumber = 4;

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
        ExampleInterrogationConvo4.EndInterrogation = true;
        ExampleInterrogationConvo4.NoQuestions = false;
        ExampleInterrogationConvo4.Response = "*Damien gets defensive* I don't see anything wrong with that";
        //Creating a Question

        ExampleInterrogationConvo4.Question1 = new Question();
        ExampleInterrogationConvo4.Question1.QuestionText = "If you say so...";
        ExampleInterrogationConvo4.Question1.NextElementNumber = 0;

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
        ExampleInterrogationConvo5.Response = "His recharge station should be right next to Rachel's room";
        //Creating a Question

        ExampleInterrogationConvo5.Question1 = new Question();
        ExampleInterrogationConvo5.Question1.QuestionText = "Oh really...";
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
        // After clue Dialogue is created the same way as Interrogation Dialogue same properties no confusion
        DialogueAfterClue ExampledialogueAfterClue = new DialogueAfterClue();

        DialogueAfterClues.Add(ExampledialogueAfterClue);

    }
}

/* 
 Potential Dialogue for if Karol accuses Damien of potentially being the murderer


A: There are members in this household that strongly suspect you of being Nikki’s murderer

D: Me?!
    
A: Yes, and I might be inclined to agree! When I found Nikki, 
there was a pipe in the corner of the room. Did you use this to attack Nikki?

D: I assure you Detective, I’m the last person here who would want Nikki dead. 
She’s the only person who was willing to take me in as an apprentice.

A: Really? And yet I hear that she was thinking of replacing you!

D:I don’t know about that. But I do know that Nikki was already stressed 
    over the pressure she was getting from her Mother to abandon her scientific pursuits and follow in the family business.
*/
