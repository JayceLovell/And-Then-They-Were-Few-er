using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Rachel : Character
{
    public override void SetRegularConvo()
    {
        base.SetRegularConvo();
        if (GameManager.Instance.CurrentGameProgress <= 3)
        {
            DialogRegularConvo ExampleForBeforeMurder = new DialogRegularConvo();
            ExampleForBeforeMurder.NPCTalking = true;
            ExampleForBeforeMurder.Text = "(The over-controlling and overbearing mother of Nikki Test)";
            dialogForRegularConvo.Add(ExampleForBeforeMurder);

            DialogRegularConvo ExampleForBeforeMurder1 = new DialogRegularConvo();
            ExampleForBeforeMurder1.NPCTalking = false;
            ExampleForBeforeMurder1.Text = "(Ashlyn bumps into Rachel accidentally and causes her to drop her purse)";
            dialogForRegularConvo.Add(ExampleForBeforeMurder1);

            DialogRegularConvo ExampleForBeforeMurder2 = new DialogRegularConvo();
            ExampleForBeforeMurder2.NPCTalking = true;
            ExampleForBeforeMurder2.Text = "Oh!";
            dialogForRegularConvo.Add(ExampleForBeforeMurder2);

            DialogRegularConvo ExampleForBeforeMurder3 = new DialogRegularConvo();
            ExampleForBeforeMurder3.NPCTalking = true;
            ExampleForBeforeMurder3.Text = "(Rachel bends over to pick her purse)";
            dialogForRegularConvo.Add(ExampleForBeforeMurder3);

            DialogRegularConvo ExampleForBeforeMurder4 = new DialogRegularConvo();
            ExampleForBeforeMurder4.NPCTalking = false;
            ExampleForBeforeMurder4.Text = "(Ashlyn notices that a handkerchief has fallen out of the purse, and picks it up to hand it back to Rachel)";
            dialogForRegularConvo.Add(ExampleForBeforeMurder4);

            DialogRegularConvo ExampleForBeforeMurder5 = new DialogRegularConvo();
            ExampleForBeforeMurder5.NPCTalking = false;
            ExampleForBeforeMurder5.Text = "Sorry about all this. I’m Ashlyn by the way, nice to meet you.";
            dialogForRegularConvo.Add(ExampleForBeforeMurder5);

            DialogRegularConvo ExampleForBeforeMurder6 = new DialogRegularConvo();
            ExampleForBeforeMurder6.NPCTalking = false;
            ExampleForBeforeMurder6.Text = "(Ashlyn notices that Rachel looks distressed, as though she has something else on her mind)";
            dialogForRegularConvo.Add(ExampleForBeforeMurder6);

            DialogRegularConvo ExampleForBeforeMurder7 = new DialogRegularConvo();
            ExampleForBeforeMurder7.NPCTalking = true;
            ExampleForBeforeMurder7.Text = "I’m Rachel. Nikki’s Mother.";
            dialogForRegularConvo.Add(ExampleForBeforeMurder7);

            DialogRegularConvo ExampleForBeforeMurder8 = new DialogRegularConvo();
            ExampleForBeforeMurder8.NPCTalking = true;
            ExampleForBeforeMurder8.Text = "(Rachel looks like she wants to leave)";
            dialogForRegularConvo.Add(ExampleForBeforeMurder8);

            DialogRegularConvo ExampleForBeforeMurder9 = new DialogRegularConvo();
            ExampleForBeforeMurder9.NPCTalking = false;
            ExampleForBeforeMurder9.Text = "(There is a short, awkward silence)";
            dialogForRegularConvo.Add(ExampleForBeforeMurder9);

            DialogRegularConvo ExampleForBeforeMurder10 = new DialogRegularConvo();
            ExampleForBeforeMurder10.NPCTalking = false;
            ExampleForBeforeMurder10.Text = "Well, nice to meet you!";
            dialogForRegularConvo.Add(ExampleForBeforeMurder10);

            DialogRegularConvo ExampleForBeforeMurder11 = new DialogRegularConvo();
            ExampleForBeforeMurder11.NPCTalking = true;
            ExampleForBeforeMurder11.Text = "…Likewise.";
            dialogForRegularConvo.Add(ExampleForBeforeMurder11);

            DialogRegularConvo ExampleForBeforeMurder12 = new DialogRegularConvo();
            ExampleForBeforeMurder12.NPCTalking = true;
            ExampleForBeforeMurder12.Text = "(Rachel's expression, however, remains cold)";
            dialogForRegularConvo.Add(ExampleForBeforeMurder12);

            DialogRegularConvo ExampleForBeforeMurder13 = new DialogRegularConvo();
            ExampleForBeforeMurder13.NPCTalking = false;
            ExampleForBeforeMurder13.Text = "(Ashlyn turns away, feeling a bit embarrassed)";
            dialogForRegularConvo.Add(ExampleForBeforeMurder13);
        }
        else
        {

            DialogRegularConvo ExampleForAfterMurder = new DialogRegularConvo();
            ExampleForAfterMurder.NPCTalking = true;
            ExampleForAfterMurder.Text = " *crying* ";
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
        ExampleInterrogationConvo.Response = "(Rachel has her hands in her face, and is crying)";
        //Creating Questions

        ExampleInterrogationConvo.Question1 = new Question();
        ExampleInterrogationConvo.Question1.QuestionText = "Rachel, I’m so sorry for your loss.";
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
        ExampleInterrogationConvo1.NPCTalking = true;
        ExampleInterrogationConvo1.EndInterrogation = false;
        ExampleInterrogationConvo1.NoQuestions = false;
        ExampleInterrogationConvo1.Response = "I just can’t believe she’s gone. Who would do this to my poor baby?";
        //Creating a Question

        ExampleInterrogationConvo1.Question1 = new Question();
        ExampleInterrogationConvo1.Question1.QuestionText = "When did you last see Nikki?";
        ExampleInterrogationConvo1.Question1.NextElementNumber = 2;

        ExampleInterrogationConvo1.Question2 = new Question();
        ExampleInterrogationConvo1.Question2.QuestionText = "Do you need a tissue?";
        ExampleInterrogationConvo1.Question2.NextElementNumber = 5;

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
        ExampleInterrogationConvo2.Response = "After the showcase. Watson and I were helping her to clean up, " +
            "but I felt a bit faint and went to bed shortly after.";
        //Creating a Question

        ExampleInterrogationConvo2.Question1 = new Question();
        ExampleInterrogationConvo2.Question1.QuestionText = "Speaking of Watson, I haven’t seen him all night. Where could he be?";
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
        ExampleInterrogationConvo3.Response = " (a bit startled): Ah, Nikki usually shuts him down for the night before bed. " +
            "I don’t know where he is kept though.";
        //Creating a Question

        ExampleInterrogationConvo3.Question1 = new Question();
        ExampleInterrogationConvo3.Question1.QuestionText = "Ah, alright";
        ExampleInterrogationConvo3.Question1.NextElementNumber = 4;

        ExampleInterrogationConvo3.Question2 = new Question();
        ExampleInterrogationConvo3.Question2.QuestionText = "Who might know where he is?";
        ExampleInterrogationConvo3.Question2.NextElementNumber = 8;

        ExampleInterrogationConvo3.Question3 = new Question();
        ExampleInterrogationConvo3.Question3.QuestionText = " ";
        ExampleInterrogationConvo3.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo3);

        //Element 4

        DialogueForInterrogation ExampleInterrogationConvo4 = new DialogueForInterrogation();
        ExampleInterrogationConvo4.NextElementNumber = 1;
        ExampleInterrogationConvo4.NPCTalking = true;
        ExampleInterrogationConvo4.EndInterrogation = true;
        ExampleInterrogationConvo4.NoQuestions = false;
        ExampleInterrogationConvo4.Response = "May I have a moment? I just..." +
            "(Rachel turns away from Ashlyn, and starts to sob again)";



        //Creating a Question

        ExampleInterrogationConvo4.Question1 = new Question();
        ExampleInterrogationConvo4.Question1.QuestionText = "Of Course";
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
        ExampleInterrogationConvo5.Response = "No thank you, I have my handkerchief.";



        //Creating a Question

        ExampleInterrogationConvo5.Question1 = new Question();
        ExampleInterrogationConvo5.Question1.QuestionText = "Next";
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
        ExampleInterrogationConvo6.Response = "(Rachel reaches into her handbag, but can't seem to find it)";



        //Creating a Question

        ExampleInterrogationConvo6.Question1 = new Question();
        ExampleInterrogationConvo6.Question1.QuestionText = "Can't find it?";
        ExampleInterrogationConvo6.Question1.NextElementNumber = 7;

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
        ExampleInterrogationConvo7.Response = "Oh, I must have dropped it somewhere";



        //Creating a Question

        ExampleInterrogationConvo7.Question1 = new Question();
        ExampleInterrogationConvo7.Question1.QuestionText = "Ah, alright";
        ExampleInterrogationConvo7.Question1.NextElementNumber = 1;

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
        ExampleInterrogationConvo8.EndInterrogation = true;
        ExampleInterrogationConvo8.NoQuestions = false;
        ExampleInterrogationConvo8.Response = "Hm, perhaps Damien?";



        //Creating a Question

        ExampleInterrogationConvo8.Question1 = new Question();
        ExampleInterrogationConvo8.Question1.QuestionText = "I'll make sure to ask him";
        ExampleInterrogationConvo8.Question1.NextElementNumber = 1;

        ExampleInterrogationConvo8.Question2 = new Question();
        ExampleInterrogationConvo8.Question2.QuestionText = " ";
        ExampleInterrogationConvo8.Question2.NextElementNumber = 0;

        ExampleInterrogationConvo8.Question3 = new Question();
        ExampleInterrogationConvo8.Question3.QuestionText = " ";
        ExampleInterrogationConvo8.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo8);

    }
    public override void SetAfterClueConvo()
    {
        base.SetAfterClueConvo();
        DialogueAfterClue ExampledialogueAfterClue = new DialogueAfterClue();
        ExampledialogueAfterClue.CorrectClue = false;
        ExampledialogueAfterClue.EndInterrogation = true;
        ExampledialogueAfterClue.NoQuestions = true;
        ExampledialogueAfterClue.NPCTalking=true;       
        ExampledialogueAfterClue.Response = "*Stares Blankly*";
        DialogueAfterClues.Add(ExampledialogueAfterClue);

        //Right Clue Dialogue
        //Element 0
        DialogueAfterClue ExampledialogueAfterClue1 = new DialogueAfterClue();
        ExampledialogueAfterClue1.CorrectClue = true;
        ExampledialogueAfterClue1.EndInterrogation = false;
        ExampledialogueAfterClue1.NoQuestions = false;
        ExampledialogueAfterClue1.NPCTalking = true;
        ExampledialogueAfterClue1.Response = "Oh no, Watson!";
        //DialogueAfterClues.Add(ExampledialogueAfterClue1);

        //Creating a Question

        ExampledialogueAfterClue1.Question1 = new Question();
        ExampledialogueAfterClue1.Question1.QuestionText = "We found him out in the courtyard";
        ExampledialogueAfterClue1.Question1.NextElementNumber = 4;

        ExampledialogueAfterClue1.Question2 = new Question();
        ExampledialogueAfterClue1.Question2.QuestionText = "Who do you think did this to him?";
        ExampledialogueAfterClue1.Question2.NextElementNumber = 3;

        ExampledialogueAfterClue1.Question3 = new Question();
        ExampledialogueAfterClue1.Question3.QuestionText = "Why wasn't he at his recharge station? Damien had told me he charges next to your room";
        ExampledialogueAfterClue1.Question3.NextElementNumber = 1;
        //Add unique item
        DialogueAfterClues.Add(ExampledialogueAfterClue1);

        //Element 1
        DialogueAfterClue ExampledialogueAfterClue2 = new DialogueAfterClue();
        ExampledialogueAfterClue2.CorrectClue = true;
        ExampledialogueAfterClue2.EndInterrogation = true;
        ExampledialogueAfterClue2.NoQuestions = false;
        ExampledialogueAfterClue2.NPCTalking = true;
        ExampledialogueAfterClue2.Response = "I-I don't know. Like I told you earlier I left him tidying up in the main hall!";
        //DialogueAfterClues.Add(ExampledialogueAfterClue1);

        //Creating a Question

        ExampledialogueAfterClue2.Question1 = new Question();
        ExampledialogueAfterClue2.Question1.QuestionText = "But you were the last person to see him Rachel. You're sure no one else was there, besides the two of you?";
        ExampledialogueAfterClue2.Question1.NextElementNumber = 2;

        ExampledialogueAfterClue2.Question2 = new Question();
        ExampledialogueAfterClue2.Question2.QuestionText = " ";
        ExampledialogueAfterClue2.Question2.NextElementNumber = 0;

        ExampledialogueAfterClue2.Question3 = new Question();
        ExampledialogueAfterClue2.Question3.QuestionText = " ";
        ExampledialogueAfterClue2.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueAfterClues.Add(ExampledialogueAfterClue2);

        //Element 2
        DialogueAfterClue ExampledialogueAfterClue3 = new DialogueAfterClue();
        ExampledialogueAfterClue3.CorrectClue = true;
        ExampledialogueAfterClue3.EndInterrogation = true;
        ExampledialogueAfterClue3.NoQuestions = false;
        ExampledialogueAfterClue3.NPCTalking = true;
        ExampledialogueAfterClue3.Response = "*shaking* I'm certain";
        //DialogueAfterClues.Add(ExampledialogueAfterClue1);

        //Creating a Question

        ExampledialogueAfterClue3.Question1 = new Question();
        ExampledialogueAfterClue3.Question1.QuestionText = "I see";
        ExampledialogueAfterClue3.Question1.NextElementNumber = 0;

        ExampledialogueAfterClue3.Question2 = new Question();
        ExampledialogueAfterClue3.Question2.QuestionText = " ";
        ExampledialogueAfterClue3.Question2.NextElementNumber = 0;

        ExampledialogueAfterClue3.Question3 = new Question();
        ExampledialogueAfterClue3.Question3.QuestionText = " ";
        ExampledialogueAfterClue3.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueAfterClues.Add(ExampledialogueAfterClue3);

        //Element 3
        DialogueAfterClue ExampledialogueAfterClue4 = new DialogueAfterClue();
        ExampledialogueAfterClue4.CorrectClue = true;
        ExampledialogueAfterClue4.EndInterrogation = false;
        ExampledialogueAfterClue4.NoQuestions = false;
        ExampledialogueAfterClue4.NPCTalking = true;
        ExampledialogueAfterClue4.Response = "Anti-Robot Enthusiasts? How would I know??";
        //DialogueAfterClues.Add(ExampledialogueAfterClue1);

        //Creating a Question

        ExampledialogueAfterClue4.Question1 = new Question();
        ExampledialogueAfterClue4.Question1.QuestionText = "Hmm";
        ExampledialogueAfterClue4.Question1.NextElementNumber = 0;

        ExampledialogueAfterClue4.Question2 = new Question();
        ExampledialogueAfterClue4.Question2.QuestionText = " ";
        ExampledialogueAfterClue4.Question2.NextElementNumber = 0;

        ExampledialogueAfterClue4.Question3 = new Question();
        ExampledialogueAfterClue4.Question3.QuestionText = " ";
        ExampledialogueAfterClue4.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueAfterClues.Add(ExampledialogueAfterClue4);

        //Element 4
        DialogueAfterClue ExampledialogueAfterClue5 = new DialogueAfterClue();
        ExampledialogueAfterClue5.CorrectClue = true;
        ExampledialogueAfterClue5.EndInterrogation = false;
        ExampledialogueAfterClue5.NoQuestions = false;
        ExampledialogueAfterClue5.NPCTalking = true;
        ExampledialogueAfterClue5.Response = "*avoids eye contact* What a strange place for him to be...";
        //DialogueAfterClues.Add(ExampledialogueAfterClue1);

        //Creating a Question

        ExampledialogueAfterClue5.Question1 = new Question();
        ExampledialogueAfterClue5.Question1.QuestionText = "Hmmm";
        ExampledialogueAfterClue5.Question1.NextElementNumber = 0;

        ExampledialogueAfterClue5.Question2 = new Question();
        ExampledialogueAfterClue5.Question2.QuestionText = " ";
        ExampledialogueAfterClue5.Question2.NextElementNumber = 0;

        ExampledialogueAfterClue5.Question3 = new Question();
        ExampledialogueAfterClue5.Question3.QuestionText = " ";
        ExampledialogueAfterClue5.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueAfterClues.Add(ExampledialogueAfterClue5);

    }
}

/* 
 Potential Dialogue  
 


*/
