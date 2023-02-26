using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OldCrazyMan : Character
{

    public override void SetRegularConvo()
    {
        base.SetRegularConvo();
        if (GameManager.Instance.CurrentGameProgress <= 3)

        {
            DialogRegularConvo ExampleForBeforeMurder = new DialogRegularConvo();
            ExampleForBeforeMurder.NPCTalking = true;
            ExampleForBeforeMurder.Text = "(The father of John. Very random, loud and rude)";
            dialogForRegularConvo.Add(ExampleForBeforeMurder);

            DialogRegularConvo ExampleForBeforeMurder1 = new DialogRegularConvo();
            ExampleForBeforeMurder1.NPCTalking = true;
            ExampleForBeforeMurder1.Text = "Do you smell it in the air?";
            dialogForRegularConvo.Add(ExampleForBeforeMurder1);

            DialogRegularConvo ExampleForBeforeMurder2 = new DialogRegularConvo();
            ExampleForBeforeMurder2.NPCTalking = false;
            ExampleForBeforeMurder2.Text = "Excuse me? Smell what?";
            dialogForRegularConvo.Add(ExampleForBeforeMurder2);

            DialogRegularConvo ExampleForBeforeMurder3 = new DialogRegularConvo();
            ExampleForBeforeMurder3.NPCTalking = true;
            ExampleForBeforeMurder3.Text = "The gears of course! I love the smell of freshly oiled gears!";
            dialogForRegularConvo.Add(ExampleForBeforeMurder3);

            DialogRegularConvo ExampleForBeforeMurder4 = new DialogRegularConvo();
            ExampleForBeforeMurder4.NPCTalking = true;
            ExampleForBeforeMurder4.Text = "(The Crazy Old Man has an excited but wild look about him)";
            dialogForRegularConvo.Add(ExampleForBeforeMurder4);

            DialogRegularConvo ExampleForBeforeMurder5 = new DialogRegularConvo();
            ExampleForBeforeMurder5.NPCTalking = false;
            ExampleForBeforeMurder5.Text = "Well, I can kind of relate. I like the smell of fresh ink and newly printed parchment paper";
            dialogForRegularConvo.Add(ExampleForBeforeMurder5);

            DialogRegularConvo ExampleForBeforeMurder6 = new DialogRegularConvo();
            ExampleForBeforeMurder6.NPCTalking = false;
            ExampleForBeforeMurder6.Text = "(Ashlyn smiles cheekily)";
            dialogForRegularConvo.Add(ExampleForBeforeMurder6);

            DialogRegularConvo ExampleForBeforeMurder7= new DialogRegularConvo();
            ExampleForBeforeMurder7.NPCTalking = true;
            ExampleForBeforeMurder7.Text = "Ink? Parchment! Now that's just weird";
            dialogForRegularConvo.Add(ExampleForBeforeMurder7);

            DialogRegularConvo ExampleForBeforeMurder8 = new DialogRegularConvo();
            ExampleForBeforeMurder8.NPCTalking = true;
            ExampleForBeforeMurder8.Text = "The Crazy Old Man sticks his tongue out at Ashlyn and starts muttering to himself as Ashlyn walks away)";
            dialogForRegularConvo.Add(ExampleForBeforeMurder8);
        }
        else
        {

            DialogRegularConvo ExampleForAfterMurder = new DialogRegularConvo();
            ExampleForAfterMurder.NPCTalking = true;
            ExampleForAfterMurder.Text = "Precious....My precious gears, are they safe?";
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
        ExampleInterrogationConvo.Question2.QuestionText = "How do you know Nikki? Why are you here?";
        ExampleInterrogationConvo.Question2.NextElementNumber = 4;

        ExampleInterrogationConvo.Question3 = new Question();
        ExampleInterrogationConvo.Question3.QuestionText = " ";
        ExampleInterrogationConvo.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo);

        //Element 1

        DialogueForInterrogation ExampleInterrogationConvo1 = new DialogueForInterrogation();
        ExampleInterrogationConvo1.NextElementNumber = 1;
        ExampleInterrogationConvo1.NPCTalking = true;
        ExampleInterrogationConvo1.EndInterrogation = false;
        ExampleInterrogationConvo1.NoQuestions = false;
        ExampleInterrogationConvo1.Response = "I was in the bathroom.";
        //Creating a Question

        ExampleInterrogationConvo1.Question1 = new Question();
        ExampleInterrogationConvo1.Question1.QuestionText = "Can anyone verify that you were there?";
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
        ExampleInterrogationConvo2.Response = "Yes, my son was inside with me.";
        //Creating a Question

        ExampleInterrogationConvo2.Question1 = new Question();
        ExampleInterrogationConvo2.Question1.QuestionText = "Your son was in the stall with you? Why??";
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
        ExampleInterrogationConvo3.EndInterrogation = true;
        ExampleInterrogationConvo3.NoQuestions = false;
        ExampleInterrogationConvo3.Response = "I always ask him to accompany me so that I have someone to hold my gears. Don’t want to drop them in the toilet!";
        //Creating a Question

        ExampleInterrogationConvo3.Question1 = new Question();
        ExampleInterrogationConvo3.Question1.QuestionText = " ";
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
        ExampleInterrogationConvo4.NPCTalking = true;
        ExampleInterrogationConvo4.EndInterrogation = false;
        ExampleInterrogationConvo4.NoQuestions = false;
        ExampleInterrogationConvo4.Response = "I don't know Nikki. How do YOU know her? Why are YOU here?";
        //Creating a Question

        ExampleInterrogationConvo4.Question1 = new Question();
        ExampleInterrogationConvo4.Question1.QuestionText = "Excuse me?";
        ExampleInterrogationConvo4.Question1.NextElementNumber = 5;

        ExampleInterrogationConvo4.Question2 = new Question();
        ExampleInterrogationConvo4.Question2.QuestionText = "I'm the one asking the questions here!";
        ExampleInterrogationConvo4.Question2.NextElementNumber = 0;

        ExampleInterrogationConvo4.Question3 = new Question();
        ExampleInterrogationConvo4.Question3.QuestionText = "Well, Nikki and I go WAY back. It all started when... ";
        ExampleInterrogationConvo4.Question3.NextElementNumber = 9;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo4);

        //Element 5

        DialogueForInterrogation ExampleInterrogationConvo5 = new DialogueForInterrogation();
        ExampleInterrogationConvo5.NextElementNumber = 1;
        ExampleInterrogationConvo5.NPCTalking = true;
        ExampleInterrogationConvo5.EndInterrogation = false;
        ExampleInterrogationConvo5.NoQuestions = false;
        ExampleInterrogationConvo5.Response = "You heard me! How do we know it wasn't you that murdered Nikki?!";
        //Creating a Question

        ExampleInterrogationConvo5.Question1 = new Question();
        ExampleInterrogationConvo5.Question1.QuestionText = "*Step forward and slap the Old Man*";
        ExampleInterrogationConvo5.Question1.NextElementNumber = 6;

        ExampleInterrogationConvo5.Question2 = new Question();
        ExampleInterrogationConvo5.Question2.QuestionText = "I didn't! I was on my way to get a glass of milk when I noticed the lab door ajar, and Nikki's body on the ground";
        ExampleInterrogationConvo5.Question2.NextElementNumber = 7;

        ExampleInterrogationConvo5.Question3 = new Question();
        ExampleInterrogationConvo5.Question3.QuestionText = " ";
        ExampleInterrogationConvo5.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo5);

        //Element 6

        DialogueForInterrogation ExampleInterrogationConvo6 = new DialogueForInterrogation();
        ExampleInterrogationConvo6.NextElementNumber = 1;
        ExampleInterrogationConvo6.NPCTalking = true;
        ExampleInterrogationConvo6.EndInterrogation = true;
        ExampleInterrogationConvo6.NoQuestions = false;
        ExampleInterrogationConvo6.Response = "*clutching his cheek* I'm sorry. I shouldn't have said that, she was your best friend after all";
        //Creating a Question

        ExampleInterrogationConvo6.Question1 = new Question();
        ExampleInterrogationConvo6.Question1.QuestionText = " ";
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
        ExampleInterrogationConvo7.Response = "A likely story! Who wakes up to get a glass of milk in the middle of the night? Preposterous!";
        //Creating a Question

        ExampleInterrogationConvo7.Question1 = new Question();
        ExampleInterrogationConvo7.Question1.QuestionText = "*clutches face in disbelief* Okay, we're getting a bit sidetracked here. I'll ask again...";
        ExampleInterrogationConvo7.Question1.NextElementNumber = 0;

        ExampleInterrogationConvo7.Question2 = new Question();
        ExampleInterrogationConvo7.Question2.QuestionText = "I was thirsty!";
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
        ExampleInterrogationConvo8.Response = "*Narrows his eyes* ";
        //Creating a Question

        ExampleInterrogationConvo8.Question1 = new Question();
        ExampleInterrogationConvo8.Question1.QuestionText = "Hey! Let's get back on track. Now... ";
        ExampleInterrogationConvo8.Question1.NextElementNumber = 0;

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
        ExampleInterrogationConvo9.Response = "*Starts to sob after listening to Ashlyn lengthily explain her friendship with Nikki*";
        //Creating a Question

        ExampleInterrogationConvo9.Question1 = new Question();
        ExampleInterrogationConvo9.Question1.QuestionText = "Next";
        ExampleInterrogationConvo9.Question1.NextElementNumber = 10;

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
        ExampleInterrogationConvo10.Response = "*sniffs* For you to lose such a dear friend... I can't even imagine what would happen if I were to lose one of my precious gears... *clutches gear to his chest*";
        //Creating a Question

        ExampleInterrogationConvo10.Question1 = new Question();
        ExampleInterrogationConvo10.Question1.QuestionText = "*rolling her eyes* ...Thanks? Now, back to the questions...";
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
        base.SetAfterClueConvo();
        DialogueAfterClue ExampledialogueAfterClue = new DialogueAfterClue();
        ExampledialogueAfterClue.CorrectClue = false;
        ExampledialogueAfterClue.EndInterrogation = true;
        ExampledialogueAfterClue.NoQuestions = true;
        ExampledialogueAfterClue.NPCTalking = true;
        ExampledialogueAfterClue.Response = "I'm sorry, if it's not a gear bit, I don't wanna hear about it";
        DialogueAfterClues.Add(ExampledialogueAfterClue);

        //Right Clue Dialogue
        //Element 0
        DialogueAfterClue ExampledialogueAfterClue1 = new DialogueAfterClue();
        ExampledialogueAfterClue1.CorrectClue = true;
        ExampledialogueAfterClue1.EndInterrogation = false;
        ExampledialogueAfterClue1.NoQuestions = false;
        ExampledialogueAfterClue1.NPCTalking = true;
        ExampledialogueAfterClue1.Response = "Oh, you found my pipey!";
        //DialogueAfterClues.Add(ExampledialogueAfterClue1);

        //Creating a Question

        ExampledialogueAfterClue1.Question1 = new Question();
        ExampledialogueAfterClue1.Question1.QuestionText = "Pipey??";
        ExampledialogueAfterClue1.Question1.NextElementNumber = 1;

        ExampledialogueAfterClue1.Question2 = new Question();
        ExampledialogueAfterClue1.Question2.QuestionText = " ";
        ExampledialogueAfterClue1.Question2.NextElementNumber = 0;

        ExampledialogueAfterClue1.Question3 = new Question();
        ExampledialogueAfterClue1.Question3.QuestionText = " ";
        ExampledialogueAfterClue1.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueAfterClues.Add(ExampledialogueAfterClue1);

        //Element 1
        DialogueAfterClue ExampledialogueAfterClue2 = new DialogueAfterClue();
        ExampledialogueAfterClue2.CorrectClue = true;
        ExampledialogueAfterClue2.EndInterrogation = true;
        ExampledialogueAfterClue2.NoQuestions = false;
        ExampledialogueAfterClue2.NPCTalking = true;
        ExampledialogueAfterClue2.Response = "Yes, Pipey! My pet pipe";
        //DialogueAfterClues.Add(ExampledialogueAfterClue1);

        //Creating a Question

        ExampledialogueAfterClue2.Question1 = new Question();
        ExampledialogueAfterClue2.Question1.QuestionText = " ";
        ExampledialogueAfterClue2.Question1.NextElementNumber = 1;

        ExampledialogueAfterClue2.Question2 = new Question();
        ExampledialogueAfterClue2.Question2.QuestionText = " ";
        ExampledialogueAfterClue2.Question2.NextElementNumber = 0;

        ExampledialogueAfterClue2.Question3 = new Question();
        ExampledialogueAfterClue2.Question3.QuestionText = " ";
        ExampledialogueAfterClue2.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueAfterClues.Add(ExampledialogueAfterClue2);

    }
}

/* 
 Where were you at the time of the murder? element 1

    response: I was in the bathroom.
    

    Can anyone verify that you were there? element 2

    response: Yes, my son was inside with me.
     
     Your son was in the stall with you? Why?? element 3

    response: I always ask him to accompany me so that I have someone to hold my gears. Don’t want to drop them in the toilet!
*/
