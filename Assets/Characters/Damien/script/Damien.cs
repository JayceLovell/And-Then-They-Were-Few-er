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
        if (GameManager.Instance.PlayerProgress == GameManager.GameState.BeforeMurder)
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
            ExampleForAfterMurder.Text = "Poor Nikki...";
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
        ExampleInterrogationConvo.Question2.QuestionText = "Do you know where Wattson is?";
        ExampleInterrogationConvo.Question2.NextElementNumber = 5;

        ExampleInterrogationConvo.Question3 = new Question();
        ExampleInterrogationConvo.Question3.QuestionText = "Is there anyone here that has a grudge against Nikki? ";
        ExampleInterrogationConvo.Question3.NextElementNumber = 6;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo);

        //Element 1

        DialogueForInterrogation ExampleInterrogationConvo1 = new DialogueForInterrogation();
        ExampleInterrogationConvo1.NextElementNumber = 1;
        ExampleInterrogationConvo1.NPCTalking = true;
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
        ExampleInterrogationConvo2.NPCTalking = true;
        ExampleInterrogationConvo2.EndInterrogation = false;
        ExampleInterrogationConvo2.NoQuestions = false;
        ExampleInterrogationConvo2.Response = "Yes, Karol was with me.";
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
        ExampleInterrogationConvo3.NPCTalking = true;
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
        ExampleInterrogationConvo4.NPCTalking = true;
        ExampleInterrogationConvo4.EndInterrogation = false;
        ExampleInterrogationConvo4.NoQuestions = false;
        ExampleInterrogationConvo4.Response = "*Damien gets defensive* I don't see anything wrong with that.";
        //Creating a Question

        ExampleInterrogationConvo4.Question1 = new Question();
        ExampleInterrogationConvo4.Question1.QuestionText = "If you say so... [Back to the first screen]";
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
        ExampleInterrogationConvo5.NPCTalking = true;
        ExampleInterrogationConvo5.EndInterrogation = false;
        ExampleInterrogationConvo5.NoQuestions = false;
        ExampleInterrogationConvo5.Response = "His recharge station should be right next to Rachel's room.";
        //Creating a Question

        ExampleInterrogationConvo5.Question1 = new Question();
        ExampleInterrogationConvo5.Question1.QuestionText = "Oh really... [Back to the first screen]";
        ExampleInterrogationConvo5.Question1.NextElementNumber = 0;

        ExampleInterrogationConvo5.Question2 = new Question();
        ExampleInterrogationConvo5.Question2.QuestionText = " ";
        ExampleInterrogationConvo5.Question2.NextElementNumber = 0;

        ExampleInterrogationConvo5.Question3 = new Question();
        ExampleInterrogationConvo5.Question3.QuestionText = " ";
        ExampleInterrogationConvo5.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo5);

        //Element 6

        DialogueForInterrogation ExampleInterrogationConvo6 = new DialogueForInterrogation();
        ExampleInterrogationConvo6.NextElementNumber = 1;
        ExampleInterrogationConvo6.NPCTalking = true;
        ExampleInterrogationConvo6.EndInterrogation = false;
        ExampleInterrogationConvo6.NoQuestions = false;
        ExampleInterrogationConvo6.Response = "I don't believe so... Nikki got on well with everyone.";
        //Creating a Question

        ExampleInterrogationConvo6.Question1 = new Question();
        ExampleInterrogationConvo6.Question1.QuestionText = "How about Karol?";
        ExampleInterrogationConvo6.Question1.NextElementNumber = 7;

        ExampleInterrogationConvo6.Question2 = new Question();
        ExampleInterrogationConvo6.Question2.QuestionText = "How about Mirianne? ";
        ExampleInterrogationConvo6.Question2.NextElementNumber = 10;

        ExampleInterrogationConvo6.Question3 = new Question();
        ExampleInterrogationConvo6.Question3.QuestionText = "Ah, okay [Back to the first screen]";
        ExampleInterrogationConvo6.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo6);

        //Element 7

        DialogueForInterrogation ExampleInterrogationConvo7 = new DialogueForInterrogation();
        ExampleInterrogationConvo7.NextElementNumber = 1;
        ExampleInterrogationConvo7.NPCTalking = true;
        ExampleInterrogationConvo7.EndInterrogation = false;
        ExampleInterrogationConvo7.NoQuestions = false;
        ExampleInterrogationConvo7.Response = "Okay yes, Karol and Nikki are... were rivals, but they did respect one another.";
        //Creating a Question

        ExampleInterrogationConvo7.Question1 = new Question();
        ExampleInterrogationConvo7.Question1.QuestionText = "Fair Enough [Back to the first screen]";
        ExampleInterrogationConvo7.Question1.NextElementNumber = 0;

        ExampleInterrogationConvo7.Question2 = new Question();
        ExampleInterrogationConvo7.Question2.QuestionText = "But with Nikki gone, Karol basically has no competition left in Wandermere... ";
        ExampleInterrogationConvo7.Question2.NextElementNumber = 8;

        ExampleInterrogationConvo7.Question3 = new Question();
        ExampleInterrogationConvo7.Question3.QuestionText = " ";
        ExampleInterrogationConvo7.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo7);

        //Element 8

        DialogueForInterrogation ExampleInterrogationConvo8 = new DialogueForInterrogation();
        ExampleInterrogationConvo8.NextElementNumber = 1;
        ExampleInterrogationConvo8.NPCTalking = true;
        ExampleInterrogationConvo8.EndInterrogation = false;
        ExampleInterrogationConvo8.NoQuestions = false;
        ExampleInterrogationConvo8.Response = "*stands up* Detective, I know Karol. She wouldn't do this.";
        //Creating a Question

        ExampleInterrogationConvo8.Question1 = new Question();
        ExampleInterrogationConvo8.Question1.QuestionText = "*eyebrow raised* Hm, okay (Back to the first screen)";
        ExampleInterrogationConvo8.Question1.NextElementNumber = 0;

        ExampleInterrogationConvo8.Question2 = new Question();
        ExampleInterrogationConvo8.Question2.QuestionText = "How exactly do you 'know' Karol?";
        ExampleInterrogationConvo8.Question2.NextElementNumber = 9;

        ExampleInterrogationConvo8.Question3 = new Question();
        ExampleInterrogationConvo8.Question3.QuestionText = " ";
        ExampleInterrogationConvo8.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo8);

        //Element 9

        DialogueForInterrogation ExampleInterrogationConvo9 = new DialogueForInterrogation();
        ExampleInterrogationConvo9.NextElementNumber = 1;
        ExampleInterrogationConvo9.NPCTalking = true;
        ExampleInterrogationConvo9.EndInterrogation = false;
        ExampleInterrogationConvo9.NoQuestions = false;
        ExampleInterrogationConvo9.Response = "*Damien remains silent* ";
        //Creating a Question

        ExampleInterrogationConvo9.Question1 = new Question();
        ExampleInterrogationConvo9.Question1.QuestionText = "(Thinking to herself) It seems I might need something more to get him to open up about Karol [Back to the first screen]";
        ExampleInterrogationConvo9.Question1.NextElementNumber = 0;

        ExampleInterrogationConvo9.Question2 = new Question();
        ExampleInterrogationConvo9.Question2.QuestionText = " ";
        ExampleInterrogationConvo9.Question2.NextElementNumber = 0;

        ExampleInterrogationConvo9.Question3 = new Question();
        ExampleInterrogationConvo9.Question3.QuestionText = " ";
        ExampleInterrogationConvo9.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo9);

        //Element 10

        DialogueForInterrogation ExampleInterrogationConvo10 = new DialogueForInterrogation();
        ExampleInterrogationConvo10.NextElementNumber = 1;
        ExampleInterrogationConvo10.NPCTalking = true;
        ExampleInterrogationConvo10.EndInterrogation = false;
        ExampleInterrogationConvo10.NoQuestions = false;
        ExampleInterrogationConvo10.Response = "As far as I know, Nikki and Mirianne had never met before tonight. ";
        //Creating a Question

        ExampleInterrogationConvo10.Question1 = new Question();
        ExampleInterrogationConvo10.Question1.QuestionText = "Ah, alright [Back to the first screen]";
        ExampleInterrogationConvo10.Question1.NextElementNumber = 0;

        ExampleInterrogationConvo10.Question2 = new Question();
        ExampleInterrogationConvo10.Question2.QuestionText = " ";
        ExampleInterrogationConvo10.Question2.NextElementNumber = 0;

        ExampleInterrogationConvo10.Question3 = new Question();
        ExampleInterrogationConvo10.Question3.QuestionText = " ";
        ExampleInterrogationConvo10.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo10);
    }

    public override void SetAfterClueConvo()
    {

        // After clue Dialogue is created the same way as Interrogation Dialogue same properties no confusion
        base.SetAfterClueConvo();
        DialogueAfterClue ExampledialogueAfterClue = new DialogueAfterClue();
        ExampledialogueAfterClue.CorrectClue = false;
        ExampledialogueAfterClue.EndInterrogation = false;
        ExampledialogueAfterClue.NoQuestions = true;
        ExampledialogueAfterClue.NPCTalking = true;
        ExampledialogueAfterClue.Response = " What's that? [It seems this is not the right clue for Damien...]";
        DialogueAfterClues.Add(ExampledialogueAfterClue);

        //Right Clue Dialogue
        //Element 1
        DialogueAfterClue ExampledialogueAfterClue1 = new DialogueAfterClue();
        ExampledialogueAfterClue1.CorrectClue = true;
        ExampledialogueAfterClue1.EndInterrogation = false;
        ExampledialogueAfterClue1.NoQuestions = false;
        ExampledialogueAfterClue1.NPCTalking = true;
        ExampledialogueAfterClue1.Response = "How did you get that?! ";
        //DialogueAfterClues.Add(ExampledialogueAfterClue1);

        //Creating a Question

        ExampledialogueAfterClue1.Question1 = new Question();
        ExampledialogueAfterClue1.Question1.QuestionText = "I found it in your room. Care to explain? ";
        ExampledialogueAfterClue1.Question1.NextElementNumber = 2;

        ExampledialogueAfterClue1.Question2 = new Question();
        ExampledialogueAfterClue1.Question2.QuestionText = " ";
        ExampledialogueAfterClue1.Question2.NextElementNumber = 0;

        ExampledialogueAfterClue1.Question3 = new Question();
        ExampledialogueAfterClue1.Question3.QuestionText = " ";
        ExampledialogueAfterClue1.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueAfterClues.Add(ExampledialogueAfterClue1);

        //Element 2
        DialogueAfterClue ExampledialogueAfterClue2 = new DialogueAfterClue();
        ExampledialogueAfterClue2.CorrectClue = true;
        ExampledialogueAfterClue2.EndInterrogation = false;
        ExampledialogueAfterClue2.NoQuestions = false;
        ExampledialogueAfterClue2.NPCTalking = true;
        ExampledialogueAfterClue2.Response = "It's a letter that I had written Karol...";
        //DialogueAfterClues.Add(ExampledialogueAfterClue2);

        //Creating a Question

        ExampledialogueAfterClue2.Question1 = new Question();
        ExampledialogueAfterClue2.Question1.QuestionText = "And what are the contents of this letter?";
        ExampledialogueAfterClue2.Question1.NextElementNumber = 3;

        ExampledialogueAfterClue2.Question2 = new Question();
        ExampledialogueAfterClue2.Question2.QuestionText = "Why keep this hidden?";
        ExampledialogueAfterClue2.Question2.NextElementNumber = 7;

        ExampledialogueAfterClue2.Question3 = new Question();
        ExampledialogueAfterClue2.Question3.QuestionText = " ";
        ExampledialogueAfterClue2.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueAfterClues.Add(ExampledialogueAfterClue2);

        //Element 3
        DialogueAfterClue ExampledialogueAfterClue3 = new DialogueAfterClue();
        ExampledialogueAfterClue3.CorrectClue = true;
        ExampledialogueAfterClue3.EndInterrogation = false;
        ExampledialogueAfterClue3.NoQuestions = false;
        ExampledialogueAfterClue3.NPCTalking = true;
        ExampledialogueAfterClue3.Response = "*sighs* I had written to Karol  about possibly reconsidering our relationship.";
       // DialogueAfterClues.Add(ExampledialogueAfterClue3);

        //Creating a Question

        ExampledialogueAfterClue3.Question1 = new Question();
        ExampledialogueAfterClue3.Question1.QuestionText = "Your relationship? You two are together?";
        ExampledialogueAfterClue3.Question1.NextElementNumber = 4;

        ExampledialogueAfterClue3.Question2 = new Question();
        ExampledialogueAfterClue3.Question2.QuestionText = " ";
        ExampledialogueAfterClue3.Question2.NextElementNumber = 0;

        ExampledialogueAfterClue3.Question3 = new Question();
        ExampledialogueAfterClue3.Question3.QuestionText = " ";
        ExampledialogueAfterClue3.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueAfterClues.Add(ExampledialogueAfterClue3);

        //Element 4
        DialogueAfterClue ExampledialogueAfterClue4 = new DialogueAfterClue();
        ExampledialogueAfterClue4.CorrectClue = true;
        ExampledialogueAfterClue4.EndInterrogation = false;
        ExampledialogueAfterClue4.NoQuestions = false;
        ExampledialogueAfterClue4.NPCTalking = true;
        ExampledialogueAfterClue4.Response = "Yes. We had been keeping this a secret from Nikki and Mirianne.";
        // DialogueAfterClues.Add(ExampledialogueAfterClue3);

        //Creating a Question

        ExampledialogueAfterClue4.Question1 = new Question();
        ExampledialogueAfterClue4.Question1.QuestionText = "Why?";
        ExampledialogueAfterClue4.Question1.NextElementNumber = 5;

        ExampledialogueAfterClue4.Question2 = new Question();
        ExampledialogueAfterClue4.Question2.QuestionText = "And is this the real reason that you and Karol were in the study together? ";
        ExampledialogueAfterClue4.Question2.NextElementNumber = 6;

        ExampledialogueAfterClue4.Question3 = new Question();
        ExampledialogueAfterClue4.Question3.QuestionText = " ";
        ExampledialogueAfterClue4.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueAfterClues.Add(ExampledialogueAfterClue4);

        //Element 5
        DialogueAfterClue ExampledialogueAfterClue5 = new DialogueAfterClue();
        ExampledialogueAfterClue5.CorrectClue = true;
        ExampledialogueAfterClue5.EndInterrogation = false;
        ExampledialogueAfterClue5.NoQuestions = false;
        ExampledialogueAfterClue5.NPCTalking = true;
        ExampledialogueAfterClue5.Response = "With Nikki and Karol being rivals, and Mirianne being Karol's sponsor, we didn't think they would support us.";
        // DialogueAfterClues.Add(ExampledialogueAfterClue3);

        //Creating a Question

        ExampledialogueAfterClue5.Question1 = new Question();
        ExampledialogueAfterClue5.Question1.QuestionText = "I see [Back to previous screen]";
        ExampledialogueAfterClue5.Question1.NextElementNumber = 2;

        ExampledialogueAfterClue5.Question2 = new Question();
        ExampledialogueAfterClue5.Question2.QuestionText = " ";
        ExampledialogueAfterClue5.Question2.NextElementNumber = 0;

        ExampledialogueAfterClue5.Question3 = new Question();
        ExampledialogueAfterClue5.Question3.QuestionText = " ";
        ExampledialogueAfterClue5.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueAfterClues.Add(ExampledialogueAfterClue5);

        //Element 6
        DialogueAfterClue ExampledialogueAfterClue6 = new DialogueAfterClue();
        ExampledialogueAfterClue6.CorrectClue = true;
        ExampledialogueAfterClue6.EndInterrogation = true;
        ExampledialogueAfterClue6.NoQuestions = true;
        ExampledialogueAfterClue6.NPCTalking = true;
        ExampledialogueAfterClue6.Response = " Yes";
        //Add unique item
        DialogueAfterClues.Add(ExampledialogueAfterClue6);

        //Element 7
        DialogueAfterClue ExampledialogueAfterClue7 = new DialogueAfterClue();
        ExampledialogueAfterClue7.CorrectClue = true;
        ExampledialogueAfterClue7.EndInterrogation = false;
        ExampledialogueAfterClue7.NoQuestions = false;
        ExampledialogueAfterClue7.NPCTalking = true;
        ExampledialogueAfterClue7.Response = " Well, we didn't want anyone to find it...";
        // DialogueAfterClues.Add(ExampledialogueAfterClue3);

        //Creating a Question

        ExampledialogueAfterClue7.Question1 = new Question();
        ExampledialogueAfterClue7.Question1.QuestionText = "*sternly* Don't be a smart ass. Explain";
        ExampledialogueAfterClue7.Question1.NextElementNumber = 3;

        ExampledialogueAfterClue7.Question2 = new Question();
        ExampledialogueAfterClue7.Question2.QuestionText = " ";
        ExampledialogueAfterClue7.Question2.NextElementNumber = 0;

        ExampledialogueAfterClue7.Question3 = new Question();
        ExampledialogueAfterClue7.Question3.QuestionText = " ";
        ExampledialogueAfterClue7.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueAfterClues.Add(ExampledialogueAfterClue7);



    }
}

/* 
 Potential Dialogue for if Karol accuses Damien of potentially being the murderer


A: There are members in this household that strongly suspect you of being Nikki's murderer

D: Me?!
    
A: Yes, and I might be inclined to agree! When I found Nikki, 
there was a pipe in the corner of the room. Did you use this to attack Nikki?

D: I assure you Detective, I'm the last person here who would want Nikki dead. 
She's the only person who was willing to take me in as an apprentice.

A: Really? And yet I hear that she was thinking of replacing you!

D:I don't know about that. But I do know that Nikki was already stressed 
    over the pressure she was getting from her Mother to abandon her scientific pursuits and follow in the family business.
*/
