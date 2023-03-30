using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Jayson : Character
{
    public override void SetRegularConvo()
    {
        base.SetRegularConvo();
        if (GameManager.Instance.PlayerProgress == GameManager.GameState.BeforeMurder)
        {
            DialogRegularConvo ExampleForBeforeMurder = new DialogRegularConvo();
            ExampleForBeforeMurder.NPCTalking = true;
            ExampleForBeforeMurder.Text = "(An attractive, but clumsy amateur detective)";
            dialogForRegularConvo.Add(ExampleForBeforeMurder);

            DialogRegularConvo ExampleForBeforeMurder1 = new DialogRegularConvo();
            ExampleForBeforeMurder1.NPCTalking = false;
            ExampleForBeforeMurder1.Text = "Good Evening";
            dialogForRegularConvo.Add(ExampleForBeforeMurder1);

            DialogRegularConvo ExampleForBeforeMurder2 = new DialogRegularConvo();
            ExampleForBeforeMurder2.NPCTalking = true;
            ExampleForBeforeMurder2.Text = "(Jayson smiles at Ashlyn)";
            dialogForRegularConvo.Add(ExampleForBeforeMurder2);

            DialogRegularConvo ExampleForBeforeMurder3 = new DialogRegularConvo();
            ExampleForBeforeMurder3.NPCTalking = true;
            ExampleForBeforeMurder3.Text = "Well, hello there";
            dialogForRegularConvo.Add(ExampleForBeforeMurder3);

            DialogRegularConvo ExampleForBeforeMurder4 = new DialogRegularConvo();
            ExampleForBeforeMurder4.NPCTalking = false;
            ExampleForBeforeMurder4.Text = "(Ashlyn returns Jayson’s smile)";
            dialogForRegularConvo.Add(ExampleForBeforeMurder4);

            DialogRegularConvo ExampleForBeforeMurder5 = new DialogRegularConvo();
            ExampleForBeforeMurder5.NPCTalking = false;
            ExampleForBeforeMurder5.Text = "Well, hello yourself";
            dialogForRegularConvo.Add(ExampleForBeforeMurder5);

            DialogRegularConvo ExampleForBeforeMurder6 = new DialogRegularConvo();
            ExampleForBeforeMurder6.NPCTalking = true;
            ExampleForBeforeMurder6.Text = "You're Ashlyn Hunt right? I never thought I'd get to meet Wandermere's hot new detective in the flesh";
            dialogForRegularConvo.Add(ExampleForBeforeMurder6);

            DialogRegularConvo ExampleForBeforeMurder7 = new DialogRegularConvo();
            ExampleForBeforeMurder7.NPCTalking = false;
            ExampleForBeforeMurder7.Text = "So I see my reputation precedes me, eh?";
            dialogForRegularConvo.Add(ExampleForBeforeMurder7);

            DialogRegularConvo ExampleForBeforeMurder8 = new DialogRegularConvo();
            ExampleForBeforeMurder8.NPCTalking = false;
            ExampleForBeforeMurder8.Text = "Do I live up to the stories?";
            dialogForRegularConvo.Add(ExampleForBeforeMurder8);

            DialogRegularConvo ExampleForBeforeMurder9 = new DialogRegularConvo();
            ExampleForBeforeMurder9.NPCTalking = true;
            ExampleForBeforeMurder9.Text = "(Jayson grins at Ashlyn)";
            dialogForRegularConvo.Add(ExampleForBeforeMurder9);

            DialogRegularConvo ExampleForBeforeMurder10 = new DialogRegularConvo();
            ExampleForBeforeMurder10.NPCTalking = true;
            ExampleForBeforeMurder10.Text = "That's yet to be determined";
            dialogForRegularConvo.Add(ExampleForBeforeMurder10);

            DialogRegularConvo ExampleForBeforeMurder11 = new DialogRegularConvo();
            ExampleForBeforeMurder11.NPCTalking = true;
            ExampleForBeforeMurder11.Text = "I'm afraid though, that you might have some competition";
            dialogForRegularConvo.Add(ExampleForBeforeMurder11);

            DialogRegularConvo ExampleForBeforeMurder12 = new DialogRegularConvo();
            ExampleForBeforeMurder12.NPCTalking = false;
            ExampleForBeforeMurder12.Text = "Oh? And who might that be?";
            dialogForRegularConvo.Add(ExampleForBeforeMurder12);

            DialogRegularConvo ExampleForBeforeMurder13 = new DialogRegularConvo();
            ExampleForBeforeMurder13.NPCTalking = true;
            ExampleForBeforeMurder13.Text = "(Jayson, takes a step closer, but trips and ends up falling on his front)";
            dialogForRegularConvo.Add(ExampleForBeforeMurder13);

            DialogRegularConvo ExampleForBeforeMurder14 = new DialogRegularConvo();
            ExampleForBeforeMurder14.NPCTalking = false;
            ExampleForBeforeMurder14.Text = "(Ashlyn laughs, but not in a cruel mocking way, moreso found it cute and funny)";
            dialogForRegularConvo.Add(ExampleForBeforeMurder14);

            DialogRegularConvo ExampleForBeforeMurder15 = new DialogRegularConvo();
            ExampleForBeforeMurder15.NPCTalking = true;
            ExampleForBeforeMurder15.Text = "(Jayson hurriedly picks himself up, and stretches out his hand to shake Ashlyn's)";
            dialogForRegularConvo.Add(ExampleForBeforeMurder15);

            DialogRegularConvo ExampleForBeforeMurder16 = new DialogRegularConvo();
            ExampleForBeforeMurder16.NPCTalking = true;
            ExampleForBeforeMurder16.Text = "(Jayson is winded, still comes off as confident, but is clearly a bit embarrassed)";
            dialogForRegularConvo.Add(ExampleForBeforeMurder16);

            DialogRegularConvo ExampleForBeforeMurder17 = new DialogRegularConvo();
            ExampleForBeforeMurder17.NPCTalking = true;
            ExampleForBeforeMurder17.Text = "Jayson Klutsch! I may not have your reputation quite yet, but I do believe I'm a force to be reckoned with";
            dialogForRegularConvo.Add(ExampleForBeforeMurder17);

            DialogRegularConvo ExampleForBeforeMurder18 = new DialogRegularConvo();
            ExampleForBeforeMurder18.NPCTalking = false;
            ExampleForBeforeMurder18.Text = "(Ashlyn shakes his hand back, still giggling)";
            dialogForRegularConvo.Add(ExampleForBeforeMurder18);

            DialogRegularConvo ExampleForBeforeMurder19 = new DialogRegularConvo();
            ExampleForBeforeMurder19.NPCTalking = false;
            ExampleForBeforeMurder19.Text = "Glad to make your acquaintance";
            dialogForRegularConvo.Add(ExampleForBeforeMurder19);
        }
        else
        {

            DialogRegularConvo ExampleForAfterMurder = new DialogRegularConvo();
            ExampleForAfterMurder.NPCTalking = true;
            ExampleForAfterMurder.Text = "We've got to get to the bottom of this!";
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
        ExampleInterrogationConvo.Question2.QuestionText = "How did you know Nikki?";
        ExampleInterrogationConvo.Question2.NextElementNumber = 4;

        ExampleInterrogationConvo.Question3 = new Question();
        ExampleInterrogationConvo.Question3.QuestionText = "From one detective to another, what do you think about all this?";
        ExampleInterrogationConvo.Question3.NextElementNumber = 10;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo);

        //Element 1

        DialogueForInterrogation ExampleInterrogationConvo1 = new DialogueForInterrogation();
        ExampleInterrogationConvo1.NextElementNumber = 1;
        ExampleInterrogationConvo1.NPCTalking = true;
        ExampleInterrogationConvo1.EndInterrogation = false;
        ExampleInterrogationConvo1.NoQuestions = false;
        ExampleInterrogationConvo1.Response = "Oh I was fast asleep! I was out like a lamp.";
        //Creating a Question

        ExampleInterrogationConvo1.Question1 = new Question();
        ExampleInterrogationConvo1.Question1.QuestionText = "I'm sorry, out like a lamp? That simile doesn't make sense";
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
        ExampleInterrogationConvo2.Response = "Sure it does! I mean, once you turn off a lamp it's out.";
        //Creating a Question

        ExampleInterrogationConvo2.Question1 = new Question();
        ExampleInterrogationConvo2.Question1.QuestionText = "But you can still turn it back on, so it's not really out is it?";
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
        ExampleInterrogationConvo3.Response = "(Laughs) Point is, I was asleep.";
        //Creating a Question

        ExampleInterrogationConvo3.Question1 = new Question();
        ExampleInterrogationConvo3.Question1.QuestionText = "(Sticks tongue out) It still don't make sense though [Back to the first screen]";
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
        ExampleInterrogationConvo4.Response = "I didn't know her personally, it's Damien that invited me to the event";



        //Creating a Question

        ExampleInterrogationConvo4.Question1 = new Question();
        ExampleInterrogationConvo4.Question1.QuestionText = "Oh, how do you know Damien?";
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
        ExampleInterrogationConvo5.Response = "Him and I go waaay back. Plus I wanted to make sure he was doing ok, " +
            "he had been a bit sad the past few days";



        //Creating a Question

        ExampleInterrogationConvo5.Question1 = new Question();
        ExampleInterrogationConvo5.Question1.QuestionText = "Really? What was wrong?";
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
        ExampleInterrogationConvo6.Response = "Well, I really shouldn't say...";



        //Creating a Question

        ExampleInterrogationConvo6.Question1 = new Question();
        ExampleInterrogationConvo6.Question1.QuestionText = "Ah, if it's private personal stuff, I understand ";
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
        ExampleInterrogationConvo7.Response = "Alright, I'll spill! Damien and Karol had a thing";



        //Creating a Question

        ExampleInterrogationConvo7.Question1 = new Question();
        ExampleInterrogationConvo7.Question1.QuestionText = "A thing? They were dating?";
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
        ExampleInterrogationConvo8.Response = "Well, kinda, but it had to be secret. " +
            "You know, what with Nikki being Karol's competition and all that.";



        //Creating a Question

        ExampleInterrogationConvo8.Question1 = new Question();
        ExampleInterrogationConvo8.Question1.QuestionText = "But why was he sad then?";
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
        ExampleInterrogationConvo9.Response = "He wouldn't tell me, but I just have a feeling it had something to do with Karol. " +
            "I know he felt guilty about keeping it hidden from Nikki.";



        //Creating a Question

        ExampleInterrogationConvo9.Question1 = new Question();
        ExampleInterrogationConvo9.Question1.QuestionText = "I see... [Back to the first screen]";
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
        ExampleInterrogationConvo10.Response = "It's certainly a doozy, I'll give you that!";



        //Creating a Question

        ExampleInterrogationConvo10.Question1 = new Question();
        ExampleInterrogationConvo10.Question1.QuestionText = "(rolls eyes) Gee, that's really helpful [Back to the first screen]";
        ExampleInterrogationConvo10.Question1.NextElementNumber = 0;

        ExampleInterrogationConvo10.Question2 = new Question();
        ExampleInterrogationConvo10.Question2.QuestionText = "I've been meaning to ask, what led you to pursuing detective work?";
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
        ExampleInterrogationConvo11.Response = "Oh, it was my Mum! She's... Robin Klutsch? ";



        //Creating a Question

        ExampleInterrogationConvo11.Question1 = new Question();
        ExampleInterrogationConvo11.Question1.QuestionText = "Steel Eyed Robin K? The same Robin K that solved the mystery of the exploding puppies??";
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
        ExampleInterrogationConvo12.Response = "*in a less than enthusiastic voice* That's her... ";



        //Creating a Question

        ExampleInterrogationConvo12.Question1 = new Question();
        ExampleInterrogationConvo12.Question1.QuestionText = "She's a legend! You sure do have some big shoes to fill... ";
        ExampleInterrogationConvo12.Question1.NextElementNumber = 13;

        ExampleInterrogationConvo12.Question2 = new Question();
        ExampleInterrogationConvo12.Question2.QuestionText = "So how did she solve that case? I've always wondered...";
        ExampleInterrogationConvo12.Question2.NextElementNumber = 17;

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
        ExampleInterrogationConvo13.Response = "*sighs* Don't I know it. But between you and me, I don't think detective work is my true calling";



        //Creating a Question

        ExampleInterrogationConvo13.Question1 = new Question();
        ExampleInterrogationConvo13.Question1.QuestionText = "Really? Why not?";
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
        ExampleInterrogationConvo14.EndInterrogation = false;
        ExampleInterrogationConvo14.NoQuestions = false;
        ExampleInterrogationConvo14.Response = "Well, it's like you said... being the son of Robin K casts a large shadow over me. I'm trying to follow in her footsepts, but I just don't think I'll measure up to what she has accomplished. ";



        //Creating a Question

        ExampleInterrogationConvo14.Question1 = new Question();
        ExampleInterrogationConvo14.Question1.QuestionText = "Hey, you've got to try. Things weren't easy when I started out, but I pushed through. You can do it.";
        ExampleInterrogationConvo14.Question1.NextElementNumber = 16;

        ExampleInterrogationConvo14.Question2 = new Question();
        ExampleInterrogationConvo14.Question2.QuestionText = "Well, what are you really passionate about?";
        ExampleInterrogationConvo14.Question2.NextElementNumber = 15;

        ExampleInterrogationConvo14.Question3 = new Question();
        ExampleInterrogationConvo14.Question3.QuestionText = " ";
        ExampleInterrogationConvo14.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo14);

        //Element 15

        DialogueForInterrogation ExampleInterrogationConvo15 = new DialogueForInterrogation();
        ExampleInterrogationConvo15.NextElementNumber = 1;
        ExampleInterrogationConvo15.NPCTalking = true;
        ExampleInterrogationConvo15.EndInterrogation = false;
        ExampleInterrogationConvo15.NoQuestions = false;
        ExampleInterrogationConvo15.Response = "Proving the existence of the pet illuminati!";



        //Creating a Question

        ExampleInterrogationConvo15.Question1 = new Question();
        ExampleInterrogationConvo15.Question1.QuestionText = "Ummm, let's get back on track... [Back to the first screen]";
        ExampleInterrogationConvo15.Question1.NextElementNumber = 0;

        ExampleInterrogationConvo15.Question2 = new Question();
        ExampleInterrogationConvo15.Question2.QuestionText = " ";
        ExampleInterrogationConvo15.Question2.NextElementNumber = 0;

        ExampleInterrogationConvo15.Question3 = new Question();
        ExampleInterrogationConvo15.Question3.QuestionText = " ";
        ExampleInterrogationConvo15.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo15);

        //Element 16

        DialogueForInterrogation ExampleInterrogationConvo16 = new DialogueForInterrogation();
        ExampleInterrogationConvo16.NextElementNumber = 1;
        ExampleInterrogationConvo16.NPCTalking = true;
        ExampleInterrogationConvo16.EndInterrogation = false;
        ExampleInterrogationConvo16.NoQuestions = false;
        ExampleInterrogationConvo16.Response = "I hope so... ";



        //Creating a Question

        ExampleInterrogationConvo16.Question1 = new Question();
        ExampleInterrogationConvo16.Question1.QuestionText = "*Give Jayson a reassuring smile* [Back to the first screen]";
        ExampleInterrogationConvo16.Question1.NextElementNumber = 0;

        ExampleInterrogationConvo16.Question2 = new Question();
        ExampleInterrogationConvo16.Question2.QuestionText = " ";
        ExampleInterrogationConvo16.Question2.NextElementNumber = 0;

        ExampleInterrogationConvo16.Question3 = new Question();
        ExampleInterrogationConvo16.Question3.QuestionText = " ";
        ExampleInterrogationConvo16.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo16);

        //Element 17

        DialogueForInterrogation ExampleInterrogationConvo17 = new DialogueForInterrogation();
        ExampleInterrogationConvo17.NextElementNumber = 1;
        ExampleInterrogationConvo17.NPCTalking = true;
        ExampleInterrogationConvo17.EndInterrogation = false;
        ExampleInterrogationConvo17.NoQuestions = false;
        ExampleInterrogationConvo17.Response = "She said she knew something was up when she noticed that the doggy treats were full of TNT...";



        //Creating a Question

        ExampleInterrogationConvo17.Question1 = new Question();
        ExampleInterrogationConvo17.Question1.QuestionText = "*gasps* I never would have guessed! Genius!! [Back to the first screen]";
        ExampleInterrogationConvo17.Question1.NextElementNumber = 0;

        ExampleInterrogationConvo17.Question2 = new Question();
        ExampleInterrogationConvo17.Question2.QuestionText = " ";
        ExampleInterrogationConvo17.Question2.NextElementNumber = 0;

        ExampleInterrogationConvo17.Question3 = new Question();
        ExampleInterrogationConvo17.Question3.QuestionText = " ";
        ExampleInterrogationConvo17.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo17);
    }
    public override void SetAfterClueConvo()
    {
        base.SetAfterClueConvo();
        DialogueAfterClue ExampledialogueAfterClue = new DialogueAfterClue();
        ExampledialogueAfterClue.CorrectClue = false;
        ExampledialogueAfterClue.EndInterrogation = true;
        ExampledialogueAfterClue.NoQuestions = true;
        ExampledialogueAfterClue.NPCTalking = true;
        ExampledialogueAfterClue.Response = " Intriguing!... What is it? ";
        DialogueAfterClues.Add(ExampledialogueAfterClue);

    }
}

/* 
 Potential Dialogue  
 


*/
