using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class John : Character
{
    public override void SetRegularConvo()
    {
        base.SetRegularConvo();
        if (GameManager.Instance.PlayerProgress == GameManager.GameState.BeforeMurder)
        {
            DialogRegularConvo ExampleForBeforeMurder = new DialogRegularConvo();
            ExampleForBeforeMurder.NPCTalking = true;
            ExampleForBeforeMurder.Text = "(A nervous young man)";
            dialogForRegularConvo.Add(ExampleForBeforeMurder);

            DialogRegularConvo ExampleForBeforeMurder1 = new DialogRegularConvo();
            ExampleForBeforeMurder1.NPCTalking = true;
            ExampleForBeforeMurder1.Text = "(His Dad is the Crazy Old Man)";
            dialogForRegularConvo.Add(ExampleForBeforeMurder1);

            DialogRegularConvo ExampleForBeforeMurder2 = new DialogRegularConvo();
            ExampleForBeforeMurder2.NPCTalking = false;
            ExampleForBeforeMurder2.Text = "Hi";
            dialogForRegularConvo.Add(ExampleForBeforeMurder2);

            DialogRegularConvo ExampleForBeforeMurder3 = new DialogRegularConvo();
            ExampleForBeforeMurder3.NPCTalking = true;
            ExampleForBeforeMurder3.Text = "Oh, hello there.";
            dialogForRegularConvo.Add(ExampleForBeforeMurder3);

            DialogRegularConvo ExampleForBeforeMurder4 = new DialogRegularConvo();
            ExampleForBeforeMurder4.NPCTalking = false;
            ExampleForBeforeMurder4.Text = "Come to see the showcase as well?";
            dialogForRegularConvo.Add(ExampleForBeforeMurder4);

            DialogRegularConvo ExampleForBeforeMurder5 = new DialogRegularConvo();
            ExampleForBeforeMurder5.NPCTalking = true;
            ExampleForBeforeMurder5.Text = "Yeah, but I'm worried my dad might do something to interrupt the show.";
            dialogForRegularConvo.Add(ExampleForBeforeMurder5);

            DialogRegularConvo ExampleForBeforeMurder6 = new DialogRegularConvo();
            ExampleForBeforeMurder6.NPCTalking = true;
            ExampleForBeforeMurder6.Text = "(Both turn to look at The Crazy Old Man, who is muttering something loud about gears)";
            dialogForRegularConvo.Add(ExampleForBeforeMurder6);

            DialogRegularConvo ExampleForBeforeMurder7 = new DialogRegularConvo();
            ExampleForBeforeMurder7.NPCTalking = true;
            ExampleForBeforeMurder7.Text = "Oh Dad...";
            dialogForRegularConvo.Add(ExampleForBeforeMurder7);

            DialogRegularConvo ExampleForBeforeMurder8 = new DialogRegularConvo();
            ExampleForBeforeMurder8.NPCTalking = true;
            ExampleForBeforeMurder8.Text = "(John covers his hands with his face in embarrassment)";
            dialogForRegularConvo.Add(ExampleForBeforeMurder8);
        }
        else
        {

            DialogRegularConvo ExampleForAfterMurder = new DialogRegularConvo();
            ExampleForAfterMurder.NPCTalking = true;
            ExampleForAfterMurder.Text = "I just want to go home...";
            dialogForRegularConvo.Add(ExampleForAfterMurder);
        }
    }
    public override void SetInterrogationConvo()
    {

        //Regular
        //DialogRegularConvo ExampleRegularConvo = new DialogRegularConvo();
        //ExampleRegularConvo.Text = "Example";
        //ExampleRegularConvo.NPCTalking = true;
        //dialogForRegularConvo.Add(ExampleRegularConvo);

		base.SetInterrogationConvo();

        //Interrogation
        //Element 0

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
        ExampleInterrogationConvo.Question2.QuestionText = "Who do you think might have done this to Nikki? ";
        ExampleInterrogationConvo.Question2.NextElementNumber = 10;

        ExampleInterrogationConvo.Question3 = new Question();
        ExampleInterrogationConvo.Question3.QuestionText = "Why is your Dad so obsessed with gears? ";
        ExampleInterrogationConvo.Question3.NextElementNumber = 13;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo);

        //Element 1

        DialogueForInterrogation ExampleInterrogationConvo1 = new DialogueForInterrogation();
        ExampleInterrogationConvo1.NextElementNumber = 1;
        ExampleInterrogationConvo1.NPCTalking = true;
        ExampleInterrogationConvo1.EndInterrogation = false;
        ExampleInterrogationConvo1.NoQuestions = false;
        ExampleInterrogationConvo1.Response = "I was in my room.";
        //Creating a Question

        ExampleInterrogationConvo1.Question1 = new Question();
        ExampleInterrogationConvo1.Question1.QuestionText = "Really? Your father says otherwise…";
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
        ExampleInterrogationConvo2.Response = "(John begins to blush profusely)";
        //Creating a Question

        ExampleInterrogationConvo2.Question1 = new Question();
        ExampleInterrogationConvo2.Question1.QuestionText = "Now tell me, where were you really?";
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
        ExampleInterrogationConvo3.Response = "I was in the bathroom with my Dad";
        //Creating a Question

        ExampleInterrogationConvo3.Question1 = new Question();
        ExampleInterrogationConvo3.Question1.QuestionText = "(while shaking her head): For God’s sake. Well, at least that provides an alibi for the both of you.";
        ExampleInterrogationConvo3.Question1.NextElementNumber = 4;

        ExampleInterrogationConvo3.Question2 = new Question();
        ExampleInterrogationConvo3.Question2.QuestionText = "(exasperated) How were you and your Father even invited to the event?  ";
        ExampleInterrogationConvo3.Question2.NextElementNumber = 7;

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
        ExampleInterrogationConvo4.Response = "Please don’t tell anyone! I was already scared that we would get caught last night, " +
            "someone tried to use the bathroom when we were in there!";

        //Creating a Question

        ExampleInterrogationConvo4.Question1 = new Question();
        ExampleInterrogationConvo4.Question1.QuestionText = "Hm? Do you know who this might have been?";
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
        ExampleInterrogationConvo5.NPCTalking = true;
        ExampleInterrogationConvo5.EndInterrogation = false;
        ExampleInterrogationConvo5.NoQuestions = false;
        ExampleInterrogationConvo5.Response = "No idea. But before they realized it was occupied they tried really hard to get in. " +
            "They must have need to pee really badly";
        //Creating a Question

        ExampleInterrogationConvo5.Question1 = new Question();
        ExampleInterrogationConvo5.Question1.QuestionText = "I’ll bet they did…";
        ExampleInterrogationConvo5.Question1.NextElementNumber = 6;

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
        ExampleInterrogationConvo6.Response = "After that, it seemed like they went into the next stall. " +
            "I think I might have heard something hit the floor, but I’m not sure, I didn’t look in to check.";
        //Creating a Question

        ExampleInterrogationConvo6.Question1 = new Question();
        ExampleInterrogationConvo6.Question1.QuestionText = "Back ";
        ExampleInterrogationConvo6.Question1.NextElementNumber = 0;

        ExampleInterrogationConvo6.Question2 = new Question();
        ExampleInterrogationConvo6.Question2.QuestionText = " ";
        ExampleInterrogationConvo6.Question2.NextElementNumber = 0;

        ExampleInterrogationConvo6.Question3 = new Question();
        ExampleInterrogationConvo6.Question3.QuestionText = " ";
        ExampleInterrogationConvo6.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo6);

        //Element 7

        DialogueForInterrogation ExampleInterrogationConvo7 = new DialogueForInterrogation();
        ExampleInterrogationConvo7.NextElementNumber = 1;
        ExampleInterrogationConvo7.NPCTalking = true;
        ExampleInterrogationConvo7.EndInterrogation = false;
        ExampleInterrogationConvo7.NoQuestions = false;
        ExampleInterrogationConvo7.Response = "Well, we kinda crashed the party...";
        //Creating a Question

        ExampleInterrogationConvo7.Question1 = new Question();
        ExampleInterrogationConvo7.Question1.QuestionText = "What?!";
        ExampleInterrogationConvo7.Question1.NextElementNumber = 8;

        ExampleInterrogationConvo7.Question2 = new Question();
        ExampleInterrogationConvo7.Question2.QuestionText = " ";
        ExampleInterrogationConvo7.Question2.NextElementNumber = 0;

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
        ExampleInterrogationConvo8.Response = "My Dad wandered in! I tried to grab him and run back out, " +
            "but he ended up yelling at Nikki about rusty gears, and how they should be well oiled.";
        //Creating a Question

        ExampleInterrogationConvo8.Question1 = new Question();
        ExampleInterrogationConvo8.Question1.QuestionText = "Oh my";
        ExampleInterrogationConvo8.Question1.NextElementNumber = 9;

        ExampleInterrogationConvo8.Question2 = new Question();
        ExampleInterrogationConvo8.Question2.QuestionText = " ";
        ExampleInterrogationConvo8.Question2.NextElementNumber = 0;

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
        ExampleInterrogationConvo9.Response = "Right? Luckily Nikki just found it all amusing and asked us to stay for the showcase.";
        //Creating a Question

        ExampleInterrogationConvo9.Question1 = new Question();
        ExampleInterrogationConvo9.Question1.QuestionText = "Nikki always was a kind soul...";
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
        ExampleInterrogationConvo10.Response = "I'm not sure. I didn't know Nikki too well to be honest";
        //Creating a Question

        ExampleInterrogationConvo10.Question1 = new Question();
        ExampleInterrogationConvo10.Question1.QuestionText = "Hm, what's your connection to Nikki? Why did she invite you and your father?";
        ExampleInterrogationConvo10.Question1.NextElementNumber = 7;

        ExampleInterrogationConvo10.Question2 = new Question();
        ExampleInterrogationConvo10.Question2.QuestionText = "Well, did you see anyone acting strangely before, during or after the showcase? ";
        ExampleInterrogationConvo10.Question2.NextElementNumber = 11;

        ExampleInterrogationConvo10.Question3 = new Question();
        ExampleInterrogationConvo10.Question3.QuestionText = " ";
        ExampleInterrogationConvo10.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo10);
		
		//Element 11

        DialogueForInterrogation ExampleInterrogationConvo11 = new DialogueForInterrogation();
        ExampleInterrogationConvo11.NextElementNumber = 1;
        ExampleInterrogationConvo11.NPCTalking = true;
        ExampleInterrogationConvo11.EndInterrogation = false;
        ExampleInterrogationConvo11.NoQuestions = false;
        ExampleInterrogationConvo11.Response = "Not really, I was too focused on trying to keep Dad in check ";
        //Creating a Question

        ExampleInterrogationConvo11.Question1 = new Question();
        ExampleInterrogationConvo11.Question1.QuestionText = "Not to sound rude, but what's up with your Dad? ";
        ExampleInterrogationConvo11.Question1.NextElementNumber = 12;

        ExampleInterrogationConvo11.Question2 = new Question();
        ExampleInterrogationConvo11.Question2.QuestionText = " ";
        ExampleInterrogationConvo11.Question2.NextElementNumber = 0;

        ExampleInterrogationConvo11.Question3 = new Question();
        ExampleInterrogationConvo11.Question3.QuestionText = " ";
        ExampleInterrogationConvo11.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo11);
		
		//Element 12

        DialogueForInterrogation ExampleInterrogationConvo12 = new DialogueForInterrogation();
        ExampleInterrogationConvo12.NextElementNumber = 1;
        ExampleInterrogationConvo12.NPCTalking = true;
        ExampleInterrogationConvo12.EndInterrogation = false;
        ExampleInterrogationConvo12.NoQuestions = false;
        ExampleInterrogationConvo12.Response = "He tends to be a little high strung, but he's a nice guy once you get to know him! ";
        //Creating a Question

        ExampleInterrogationConvo12.Question1 = new Question();
        ExampleInterrogationConvo12.Question1.QuestionText = "Right... ";
        ExampleInterrogationConvo12.Question1.NextElementNumber = 0;

        ExampleInterrogationConvo12.Question2 = new Question();
        ExampleInterrogationConvo12.Question2.QuestionText = "Why's he so obsessed with gears?";
        ExampleInterrogationConvo12.Question2.NextElementNumber = 13;

        ExampleInterrogationConvo12.Question3 = new Question();
        ExampleInterrogationConvo12.Question3.QuestionText = " ";
        ExampleInterrogationConvo12.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo12);
		
		//Element 13

        DialogueForInterrogation ExampleInterrogationConvo13 = new DialogueForInterrogation();
        ExampleInterrogationConvo13.NextElementNumber = 1;
        ExampleInterrogationConvo13.NPCTalking = true;
        ExampleInterrogationConvo13.EndInterrogation = false;
        ExampleInterrogationConvo13.NoQuestions = false;
        ExampleInterrogationConvo13.Response = "*John's face darkens* It's all because of Nanda Smoki, that bastard! I'll never forgive him!";
        //Creating a Question

        ExampleInterrogationConvo13.Question1 = new Question();
        ExampleInterrogationConvo13.Question1.QuestionText = "*startled* Wait, who is Nanda Smoki? ";
        ExampleInterrogationConvo13.Question1.NextElementNumber = 14;

        ExampleInterrogationConvo13.Question2 = new Question();
        ExampleInterrogationConvo13.Question2.QuestionText = " ";
        ExampleInterrogationConvo13.Question2.NextElementNumber = 0;

        ExampleInterrogationConvo13.Question3 = new Question();
        ExampleInterrogationConvo13.Question3.QuestionText = " ";
        ExampleInterrogationConvo13.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo13);
		
		//Element 14

        DialogueForInterrogation ExampleInterrogationConvo14 = new DialogueForInterrogation();
        ExampleInterrogationConvo14.NextElementNumber = 1;
        ExampleInterrogationConvo14.NPCTalking = true;
        ExampleInterrogationConvo14.EndInterrogation = true;
        ExampleInterrogationConvo14.NoQuestions = false;
        ExampleInterrogationConvo14.Response = "WE DON'T TALK ABOUT NANDA SMOKI";
        //Creating a Question

        ExampleInterrogationConvo14.Question1 = new Question();
        ExampleInterrogationConvo14.Question1.QuestionText = " ";
        ExampleInterrogationConvo14.Question1.NextElementNumber = 0;

        ExampleInterrogationConvo14.Question2 = new Question();
        ExampleInterrogationConvo14.Question2.QuestionText = " ";
        ExampleInterrogationConvo14.Question2.NextElementNumber = 0;

        ExampleInterrogationConvo14.Question3 = new Question();
        ExampleInterrogationConvo14.Question3.QuestionText = " ";
        ExampleInterrogationConvo14.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo14);
    }
    public override void SetAfterClueConvo()
    {
        base.SetAfterClueConvo();
        DialogueAfterClue ExampledialogueAfterClue = new DialogueAfterClue();
        ExampledialogueAfterClue.CorrectClue = false;
        ExampledialogueAfterClue.EndInterrogation = true;
        ExampledialogueAfterClue.NoQuestions = true;
        ExampledialogueAfterClue.NPCTalking = true;
        ExampledialogueAfterClue.Response = " I don't know!";
        DialogueAfterClues.Add(ExampledialogueAfterClue);

    }
}

/* 
 Potential Dialogue  



*/
