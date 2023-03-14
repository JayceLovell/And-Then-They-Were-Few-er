using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Mirianne : Character
{
    public override void SetRegularConvo()
    {
        base.SetRegularConvo();
        if (GameManager.Instance.PlayerProgress == GameManager.GameState.BeforeMurder)
        {
            DialogRegularConvo ExampleForBeforeMurder = new DialogRegularConvo();
            ExampleForBeforeMurder.NPCTalking = true;
            ExampleForBeforeMurder.Text = "(Miriane, a wealthy but vain trend chasing fashion designer)";
            dialogForRegularConvo.Add(ExampleForBeforeMurder);

            DialogRegularConvo ExampleForBeforeMurder1 = new DialogRegularConvo();
            ExampleForBeforeMurder1.NPCTalking = true;
            ExampleForBeforeMurder1.Text = "Oh, so you're here too, are you?";
            dialogForRegularConvo.Add(ExampleForBeforeMurder1);

            DialogRegularConvo ExampleForBeforeMurder2 = new DialogRegularConvo();
            ExampleForBeforeMurder2.NPCTalking = false;
            ExampleForBeforeMurder2.Text = "Well, hello to you too";
            dialogForRegularConvo.Add(ExampleForBeforeMurder2);

            DialogRegularConvo ExampleForBeforeMurder3 = new DialogRegularConvo();
            ExampleForBeforeMurder3.NPCTalking = true;
            ExampleForBeforeMurder3.Text = "(Mirianne stares at Ashlyn in disdain)";
            dialogForRegularConvo.Add(ExampleForBeforeMurder3);

            DialogRegularConvo ExampleForBeforeMurder4 = new DialogRegularConvo();
            ExampleForBeforeMurder4.NPCTalking = false;
            ExampleForBeforeMurder4.Text = "I'm a friend of Nikki's";
            dialogForRegularConvo.Add(ExampleForBeforeMurder4);

            DialogRegularConvo ExampleForBeforeMurder5 = new DialogRegularConvo();
            ExampleForBeforeMurder5.NPCTalking = true;
            ExampleForBeforeMurder5.Text = "(Mirianne continues to stare)";
            dialogForRegularConvo.Add(ExampleForBeforeMurder5);

            DialogRegularConvo ExampleForBeforeMurder6 = new DialogRegularConvo();
            ExampleForBeforeMurder6.NPCTalking = true;
            ExampleForBeforeMurder6.Text = "Ah, I see";
            dialogForRegularConvo.Add(ExampleForBeforeMurder6);

            DialogRegularConvo ExampleForBeforeMurder7 = new DialogRegularConvo();
            ExampleForBeforeMurder7.NPCTalking = true;
            ExampleForBeforeMurder7.Text = "Well I must admit, Nikki's built quite the reputation for herself.";
            dialogForRegularConvo.Add(ExampleForBeforeMurder7);

            DialogRegularConvo ExampleForBeforeMurder8 = new DialogRegularConvo();
            ExampleForBeforeMurder8.NPCTalking = false;
            ExampleForBeforeMurder8.Text = "(Ashlyn grins rogue-ishly)";
            dialogForRegularConvo.Add(ExampleForBeforeMurder8);

            DialogRegularConvo ExampleForBeforeMurder9 = new DialogRegularConvo();
            ExampleForBeforeMurder9.NPCTalking = false;
            ExampleForBeforeMurder9.Text = "Yeah, ol' Nikki's on the up and up";
            dialogForRegularConvo.Add(ExampleForBeforeMurder9);

            DialogRegularConvo ExampleForBeforeMurder10 = new DialogRegularConvo();
            ExampleForBeforeMurder10.NPCTalking = true;
            ExampleForBeforeMurder10.Text = "Well, she might be Wandermere's hottest new inventor, but I have a feeling that someone else will be taking her spot pretty soon...";
            dialogForRegularConvo.Add(ExampleForBeforeMurder10);

            DialogRegularConvo ExampleForBeforeMurder11 = new DialogRegularConvo();
            ExampleForBeforeMurder11.NPCTalking = true;
            ExampleForBeforeMurder11.Text = "(Ashlyn narrows her eyes at Mirianne as she walks away. Mirianne narrows hers as well )";
            dialogForRegularConvo.Add(ExampleForBeforeMurder11);
        }
        else
        {

            DialogRegularConvo ExampleForAfterMurder = new DialogRegularConvo();
            ExampleForAfterMurder.NPCTalking = true;
            ExampleForAfterMurder.Text = "I can't wait for this storm to end so I can leave this wretched mansion";
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
        ExampleInterrogationConvo.Question2.QuestionText = "How's the ol' business doing? ";
        ExampleInterrogationConvo.Question2.NextElementNumber = 15;

        ExampleInterrogationConvo.Question3 = new Question();
        ExampleInterrogationConvo.Question3.QuestionText = "What you said earlier about someone eclipsing Nikki,  what did you mean by that?";
        ExampleInterrogationConvo.Question3.NextElementNumber = 18;        
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo);

        //Element 1

        DialogueForInterrogation ExampleInterrogationConvo1 = new DialogueForInterrogation();
        ExampleInterrogationConvo1.NextElementNumber = 1;
        ExampleInterrogationConvo1.NPCTalking = true;
        ExampleInterrogationConvo1.EndInterrogation = false;
        ExampleInterrogationConvo1.NoQuestions = false;
        ExampleInterrogationConvo1.Response = "I don’t see why this is any of your business, “Detective”";
        //Creating a Question

        ExampleInterrogationConvo1.Question1 = new Question();
        ExampleInterrogationConvo1.Question1.QuestionText = "Hey! Don’t tell me you are going to undermine an active murder investigation";
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
        ExampleInterrogationConvo2.Response = "Well, last time I checked, you are not the police." +
            "I thought you and our dear Mayor were going to fetch real law enforcement once this storm cleared up";
        //Creating a Question

        ExampleInterrogationConvo2.Question1 = new Question();
        ExampleInterrogationConvo2.Question1.QuestionText = "I’d just like to know all the facts, before the Mayor and I approach the police. ";
        ExampleInterrogationConvo2.Question1.NextElementNumber = 3;

        ExampleInterrogationConvo2.Question2 = new Question();
        ExampleInterrogationConvo2.Question2.QuestionText = " ";
        ExampleInterrogationConvo2.Question2.NextElementNumber = 0;

        ExampleInterrogationConvo2.Question3 = new Question();
        ExampleInterrogationConvo2.Question3.QuestionText = "";
        ExampleInterrogationConvo2.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo2);

        //Element 3

        DialogueForInterrogation ExampleInterrogationConvo3 = new DialogueForInterrogation();
        ExampleInterrogationConvo3.NextElementNumber = 1;
        ExampleInterrogationConvo3.NPCTalking = true;
        ExampleInterrogationConvo3.EndInterrogation = false;
        ExampleInterrogationConvo3.NoQuestions = false;
        ExampleInterrogationConvo3.Response = "(Ashlyn takes a deep breath, trying to control her anger)" +
            "Ashlyn then sighs, and her tone changes  from interrogative to mournful";
        //Creating a Question

        ExampleInterrogationConvo3.Question1 = new Question();
        ExampleInterrogationConvo3.Question1.QuestionText = "There’s a potential murderer on the loose. And Nikki was my best friend. " +
            "I need to get to the bottom of this";
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
        ExampleInterrogationConvo4.Response = " (Mirianne, who had been glaring at Ashlyn, " +
            "changes her expression somewhat to a look of resentful understanding)";



        //Creating a Question

        ExampleInterrogationConvo4.Question1 = new Question();
        ExampleInterrogationConvo4.Question1.QuestionText = "Next";
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
        ExampleInterrogationConvo5.Response = "Well, if there’s one thing that hasn’t changed, it’s how much you’re willing to do for your friends…";



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
        ExampleInterrogationConvo6.Response = "If you must know, I was in [some room near the lab].";



        //Creating a Question

        ExampleInterrogationConvo6.Question1 = new Question();
        ExampleInterrogationConvo6.Question1.QuestionText = "Hold on. The Mayor says he saw you in [different room].";
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
        ExampleInterrogationConvo7.Response = "(Mirianne stutters for a bit, shocked, but quickly recovers)";



        //Creating a Question

        ExampleInterrogationConvo7.Question1 = new Question();
        ExampleInterrogationConvo7.Question1.QuestionText = "Next";
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
        ExampleInterrogationConvo8.Response = "Oh! Pardon me, I seem to have misremembered. Yes I was indeed in that room.";



        //Creating a Question

        ExampleInterrogationConvo8.Question1 = new Question();
        ExampleInterrogationConvo8.Question1.QuestionText = "Next";
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
        ExampleInterrogationConvo9.Response = "I could hear two people talking very loudly, but couldn’t make out what they were saying." +
            "The storm was too loud.";



        //Creating a Question

        ExampleInterrogationConvo9.Question1 = new Question();
        ExampleInterrogationConvo9.Question1.QuestionText = "What happened next?";
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
        ExampleInterrogationConvo10.Response = "At the time, I heard a very loud sound, which I assumed was the thunder." +
            "But now that I think about it…";



        //Creating a Question

        ExampleInterrogationConvo10.Question1 = new Question();
        ExampleInterrogationConvo10.Question1.QuestionText = "What?";
        ExampleInterrogationConvo10.Question1.NextElementNumber = 11;

        ExampleInterrogationConvo10.Question2 = new Question();
        ExampleInterrogationConvo10.Question2.QuestionText = " ";
        ExampleInterrogationConvo10.Question2.NextElementNumber = 0;

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
        ExampleInterrogationConvo11.Response = "(Mirianne begins to scowl)";



        //Creating a Question

        ExampleInterrogationConvo11.Question1 = new Question();
        ExampleInterrogationConvo11.Question1.QuestionText = "Next";
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
        ExampleInterrogationConvo12.Response = "…It may have been a body hitting the ground.";



        //Creating a Question

        ExampleInterrogationConvo12.Question1 = new Question();
        ExampleInterrogationConvo12.Question1.QuestionText = "Oh...";
        ExampleInterrogationConvo12.Question1.NextElementNumber = 13;

        ExampleInterrogationConvo12.Question2 = new Question();
        ExampleInterrogationConvo12.Question2.QuestionText = " ";
        ExampleInterrogationConvo12.Question2.NextElementNumber = 0;

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
        ExampleInterrogationConvo13.Response = "(Miriane’s expression hardens)";



        //Creating a Question

        ExampleInterrogationConvo13.Question1 = new Question();
        ExampleInterrogationConvo13.Question1.QuestionText = "Next";
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
        ExampleInterrogationConvo14.Response = "I didn’t pay it any mind. Shortly after, I left for my room." +
            "May I go now, “Detective”?";



        //Creating a Question

        ExampleInterrogationConvo14.Question1 = new Question();
        ExampleInterrogationConvo14.Question1.QuestionText = "Not Quite Yet...";
        ExampleInterrogationConvo14.Question1.NextElementNumber = 0;

        ExampleInterrogationConvo14.Question2 = new Question();
        ExampleInterrogationConvo14.Question2.QuestionText = " ";
        ExampleInterrogationConvo14.Question2.NextElementNumber = 0;

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
        ExampleInterrogationConvo15.Response = "*raises eyebrow* Wouldn't you like to know?";



        //Creating a Question

        ExampleInterrogationConvo15.Question1 = new Question();
        ExampleInterrogationConvo15.Question1.QuestionText = "Mmm, call me curious. I've heard that the Jelani fashion brand has overtaken yours in popularity....";
        ExampleInterrogationConvo15.Question1.NextElementNumber = 16;

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
        ExampleInterrogationConvo16.Response = "Nonsense! MiriFab is the #1 brand in Wandermere.";



        //Creating a Question

        ExampleInterrogationConvo16.Question1 = new Question();
        ExampleInterrogationConvo16.Question1.QuestionText = " Oh really? Tell me, who was it that was featured on the cover of Fashion Digest's 'Hot&Trending' Digest? Because I don't remember seeing you on that cover...";
        ExampleInterrogationConvo16.Question1.NextElementNumber = 17;

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
        ExampleInterrogationConvo17.Response = "Shut up! I don't see how any of this is relevant to what happened last night!";



        //Creating a Question

        ExampleInterrogationConvo17.Question1 = new Question();
        ExampleInterrogationConvo17.Question1.QuestionText = "Fair Enough. Let's get back on track...";
        ExampleInterrogationConvo17.Question1.NextElementNumber = 0;

        ExampleInterrogationConvo17.Question2 = new Question();
        ExampleInterrogationConvo17.Question2.QuestionText = " ";
        ExampleInterrogationConvo17.Question2.NextElementNumber = 0;

        ExampleInterrogationConvo17.Question3 = new Question();
        ExampleInterrogationConvo17.Question3.QuestionText = " ";
        ExampleInterrogationConvo17.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo17);
		
		//Element 18

        DialogueForInterrogation ExampleInterrogationConvo18 = new DialogueForInterrogation();
        ExampleInterrogationConvo18.NextElementNumber = 1;
        ExampleInterrogationConvo18.NPCTalking = true;
        ExampleInterrogationConvo18.EndInterrogation = false;
        ExampleInterrogationConvo18.NoQuestions = false;
        ExampleInterrogationConvo18.Response = "Oh... Well, I'm Karol's sponsor. And I do believe she has some ideas that may surpass Nikki's";



        //Creating a Question

        ExampleInterrogationConvo18.Question1 = new Question();
        ExampleInterrogationConvo18.Question1.QuestionText = "Hmm, okay...";
        ExampleInterrogationConvo18.Question1.NextElementNumber = 0;

        ExampleInterrogationConvo18.Question2 = new Question();
        ExampleInterrogationConvo18.Question2.QuestionText = "What led you to sponsoring her?";
        ExampleInterrogationConvo18.Question2.NextElementNumber = 19;

        ExampleInterrogationConvo18.Question3 = new Question();
        ExampleInterrogationConvo18.Question3.QuestionText = " ";
        ExampleInterrogationConvo18.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo18);
		
		//Element 19

        DialogueForInterrogation ExampleInterrogationConvo19 = new DialogueForInterrogation();
        ExampleInterrogationConvo19.NextElementNumber = 1;
        ExampleInterrogationConvo19.NPCTalking = true;
        ExampleInterrogationConvo19.EndInterrogation = false;
        ExampleInterrogationConvo19.NoQuestions = false;
        ExampleInterrogationConvo19.Response = "A music producer friend of mine, Lay, he recommended her. She built some of his sound machines, and he has the best beats in the business! So I thought I might put her talents to other use... ";



        //Creating a Question

        ExampleInterrogationConvo19.Question1 = new Question();
        ExampleInterrogationConvo19.Question1.QuestionText = "I see... ";
        ExampleInterrogationConvo19.Question1.NextElementNumber = 0;

        ExampleInterrogationConvo19.Question2 = new Question();
        ExampleInterrogationConvo19.Question2.QuestionText = " ";
        ExampleInterrogationConvo19.Question2.NextElementNumber = 0;

        ExampleInterrogationConvo19.Question3 = new Question();
        ExampleInterrogationConvo19.Question3.QuestionText = " ";
        ExampleInterrogationConvo19.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo19);


    }
    public override void SetAfterClueConvo()
    {
        // After clue Dialogue is created the same way as Interrogation Dialogue same properties no confusion
        base.SetAfterClueConvo();
        DialogueAfterClue ExampledialogueAfterClue = new DialogueAfterClue();
        ExampledialogueAfterClue.CorrectClue = false;
        ExampledialogueAfterClue.EndInterrogation = true;
        ExampledialogueAfterClue.NoQuestions = true;
        ExampledialogueAfterClue.NPCTalking = true;
        ExampledialogueAfterClue.Response = "Do I look like I know?";
        DialogueAfterClues.Add(ExampledialogueAfterClue);

        //Right Clue Dialogue
        //Element 0
        DialogueAfterClue ExampledialogueAfterClue1 = new DialogueAfterClue();
        ExampledialogueAfterClue1.CorrectClue = true;
        ExampledialogueAfterClue1.EndInterrogation = false;
        ExampledialogueAfterClue1.NoQuestions = false;
        ExampledialogueAfterClue1.NPCTalking = true;
        ExampledialogueAfterClue1.Response = "*stares at the handkerchief in shock*";
        //DialogueAfterClues.Add(ExampledialogueAfterClue1);

        //Creating a Question

        ExampledialogueAfterClue1.Question1 = new Question();
        ExampledialogueAfterClue1.Question1.QuestionText = "Look familiar?";
        ExampledialogueAfterClue1.Question1.NextElementNumber = 1;

        ExampledialogueAfterClue1.Question2 = new Question();
        ExampledialogueAfterClue1.Question2.QuestionText = " "; //Oh, no need to worry this is just ketchup!
        ExampledialogueAfterClue1.Question2.NextElementNumber = 0;

        ExampledialogueAfterClue1.Question3 = new Question();
        ExampledialogueAfterClue1.Question3.QuestionText = " ";
        ExampledialogueAfterClue1.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueAfterClues.Add(ExampledialogueAfterClue1);

        //Element 1
        DialogueAfterClue ExampledialogueAfterClue2 = new DialogueAfterClue();
        ExampledialogueAfterClue2.CorrectClue = true;
        ExampledialogueAfterClue2.EndInterrogation = false;
        ExampledialogueAfterClue2.NoQuestions = false;
        ExampledialogueAfterClue2.NPCTalking = true;
        ExampledialogueAfterClue2.Response = "*starts to shift uncomfortably* I... er... um";
        //DialogueAfterClues.Add(ExampledialogueAfterClue1);

        //Creating a Question

        ExampledialogueAfterClue2.Question1 = new Question();
        ExampledialogueAfterClue2.Question1.QuestionText = "What?";
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
        ExampledialogueAfterClue3.EndInterrogation = false;
        ExampledialogueAfterClue3.NoQuestions = false;
        ExampledialogueAfterClue3.NPCTalking = true;
        ExampledialogueAfterClue3.Response = "*Takes a deep breath and closes her eyes* ...I was in the room after she had been killed";
        //DialogueAfterClues.Add(ExampledialogueAfterClue1);

        //Creating a Question

        ExampledialogueAfterClue3.Question1 = new Question();
        ExampledialogueAfterClue3.Question1.QuestionText = "What?!";
        ExampledialogueAfterClue3.Question1.NextElementNumber = 3;

        ExampledialogueAfterClue3.Question2 = new Question();
        ExampledialogueAfterClue3.Question2.QuestionText = "Why?!";
        ExampledialogueAfterClue3.Question2.NextElementNumber = 4;

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
        ExampledialogueAfterClue4.Response = "*A tear streaks down Mirianne's face*";
        //DialogueAfterClues.Add(ExampledialogueAfterClue1);

        //Creating a Question

        ExampledialogueAfterClue4.Question1 = new Question();
        ExampledialogueAfterClue4.Question1.QuestionText = "Previous Screen";
        ExampledialogueAfterClue4.Question1.NextElementNumber = 2;

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
        ExampledialogueAfterClue5.Response = "Well, after I heard the two voices arguing, I went to investigate";
        //DialogueAfterClues.Add(ExampledialogueAfterClue1);

        //Creating a Question

        ExampledialogueAfterClue5.Question1 = new Question();
        ExampledialogueAfterClue5.Question1.QuestionText = "Next";
        ExampledialogueAfterClue5.Question1.NextElementNumber = 5;

        ExampledialogueAfterClue5.Question2 = new Question();
        ExampledialogueAfterClue5.Question2.QuestionText = " ";
        ExampledialogueAfterClue5.Question2.NextElementNumber = 0;

        ExampledialogueAfterClue5.Question3 = new Question();
        ExampledialogueAfterClue5.Question3.QuestionText = " ";
        ExampledialogueAfterClue5.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueAfterClues.Add(ExampledialogueAfterClue5);

        //Element 5
        DialogueAfterClue ExampledialogueAfterClue6 = new DialogueAfterClue();
        ExampledialogueAfterClue6.CorrectClue = true;
        ExampledialogueAfterClue6.EndInterrogation = false;
        ExampledialogueAfterClue6.NoQuestions = false;
        ExampledialogueAfterClue6.NPCTalking = true;
        ExampledialogueAfterClue6.Response = "I'd thought I heard them coming from the lab, and that's where I went to check. When I entered, Nikki was lying on the floor, bleeding";
        //DialogueAfterClues.Add(ExampledialogueAfterClue1);

        //Creating a Question

        ExampledialogueAfterClue6.Question1 = new Question();
        ExampledialogueAfterClue6.Question1.QuestionText = "Next";
        ExampledialogueAfterClue6.Question1.NextElementNumber = 6;

        ExampledialogueAfterClue6.Question2 = new Question();
        ExampledialogueAfterClue6.Question2.QuestionText = " ";
        ExampledialogueAfterClue6.Question2.NextElementNumber = 0;

        ExampledialogueAfterClue6.Question3 = new Question();
        ExampledialogueAfterClue6.Question3.QuestionText = " ";
        ExampledialogueAfterClue6.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueAfterClues.Add(ExampledialogueAfterClue6);

        //Element 6
        DialogueAfterClue ExampledialogueAfterClue7 = new DialogueAfterClue();
        ExampledialogueAfterClue7.CorrectClue = true;
        ExampledialogueAfterClue7.EndInterrogation = false;
        ExampledialogueAfterClue7.NoQuestions = false;
        ExampledialogueAfterClue7.NPCTalking = true;
        ExampledialogueAfterClue7.Response = "I rushed to her body to check to see if she was ok. That handkerchief was next to her, and I applied it to her wound to see if I could stop the bleeding, but it was too late. She was already dead";
        //DialogueAfterClues.Add(ExampledialogueAfterClue1);

        //Creating a Question

        ExampledialogueAfterClue7.Question1 = new Question();
        ExampledialogueAfterClue7.Question1.QuestionText = "Next";
        ExampledialogueAfterClue7.Question1.NextElementNumber = 7;

        ExampledialogueAfterClue7.Question2 = new Question();
        ExampledialogueAfterClue7.Question2.QuestionText = " ";
        ExampledialogueAfterClue7.Question2.NextElementNumber = 0;

        ExampledialogueAfterClue7.Question3 = new Question();
        ExampledialogueAfterClue7.Question3.QuestionText = " ";
        ExampledialogueAfterClue7.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueAfterClues.Add(ExampledialogueAfterClue7);

        //Element 7
        DialogueAfterClue ExampledialogueAfterClue8 = new DialogueAfterClue();
        ExampledialogueAfterClue8.CorrectClue = true;
        ExampledialogueAfterClue8.EndInterrogation = false;
        ExampledialogueAfterClue8.NoQuestions = false;
        ExampledialogueAfterClue8.NPCTalking = true;
        ExampledialogueAfterClue8.Response = "I thought about calling for help, but I panicked. I just didn't know how to explain myself without looking suspicious";
        //DialogueAfterClues.Add(ExampledialogueAfterClue1);

        //Creating a Question

        ExampledialogueAfterClue8.Question1 = new Question();
        ExampledialogueAfterClue8.Question1.QuestionText = "No kidding";
        ExampledialogueAfterClue8.Question1.NextElementNumber = 8;

        ExampledialogueAfterClue8.Question2 = new Question();
        ExampledialogueAfterClue8.Question2.QuestionText = "But this makes you look even more suspicious! ";
        ExampledialogueAfterClue8.Question2.NextElementNumber = 9;

        ExampledialogueAfterClue8.Question3 = new Question();
        ExampledialogueAfterClue8.Question3.QuestionText = " ";
        ExampledialogueAfterClue8.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueAfterClues.Add(ExampledialogueAfterClue8);

        //Element 8
        DialogueAfterClue ExampledialogueAfterClue9 = new DialogueAfterClue();
        ExampledialogueAfterClue9.CorrectClue = true;
        ExampledialogueAfterClue9.EndInterrogation = false;
        ExampledialogueAfterClue9.NoQuestions = false;
        ExampledialogueAfterClue9.NPCTalking = true;
        ExampledialogueAfterClue9.Response = "What choice did I have? Tell me, 'Detective', what would you have done in my place?";
        //DialogueAfterClues.Add(ExampledialogueAfterClue1);

        //Creating a Question

        ExampledialogueAfterClue9.Question1 = new Question();
        ExampledialogueAfterClue9.Question1.QuestionText = "*remain silent*";
        ExampledialogueAfterClue9.Question1.NextElementNumber = 9;

        ExampledialogueAfterClue9.Question2 = new Question();
        ExampledialogueAfterClue9.Question2.QuestionText = "*shakes head in exasparation* I wouldn't hide evidence! Really Mirianne?";
        ExampledialogueAfterClue9.Question2.NextElementNumber = 9;

        ExampledialogueAfterClue9.Question3 = new Question();
        ExampledialogueAfterClue9.Question3.QuestionText = " ";
        ExampledialogueAfterClue9.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueAfterClues.Add(ExampledialogueAfterClue9);

        //Element 9
        DialogueAfterClue ExampledialogueAfterClue10 = new DialogueAfterClue();
        ExampledialogueAfterClue10.CorrectClue = true;
        ExampledialogueAfterClue10.EndInterrogation = false;
        ExampledialogueAfterClue10.NoQuestions = false;
        ExampledialogueAfterClue10.NPCTalking = true;
        ExampledialogueAfterClue10.Response = "Ashlyn, I know you and I have our issues, but you have to believe me, I didn't kill Nikki";
        //DialogueAfterClues.Add(ExampledialogueAfterClue1);

        //Creating a Question

        ExampledialogueAfterClue10.Question1 = new Question();
        ExampledialogueAfterClue10.Question1.QuestionText = "Hmm... ";
        ExampledialogueAfterClue10.Question1.NextElementNumber = 0;

        ExampledialogueAfterClue10.Question2 = new Question();
        ExampledialogueAfterClue10.Question2.QuestionText = " ";
        ExampledialogueAfterClue10.Question2.NextElementNumber = 0;

        ExampledialogueAfterClue10.Question3 = new Question();
        ExampledialogueAfterClue10.Question3.QuestionText = " ";
        ExampledialogueAfterClue10.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueAfterClues.Add(ExampledialogueAfterClue10);

    }
}

/* 
 Potential Dialogue  
 


*/
