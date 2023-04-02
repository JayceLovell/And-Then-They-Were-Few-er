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
        // Load regular text before murder
        if (GameManager.Instance.PlayerProgress == GameManager.GameState.BeforeMurder)
        {
            DialogRegularConvo ExampleForBeforeMurder = new DialogRegularConvo();
            ExampleForBeforeMurder.NPCTalking = true;
            ExampleForBeforeMurder.Text = "(The Mayor of the Wandermere)";
            dialogForRegularConvo.Add(ExampleForBeforeMurder);

            DialogRegularConvo ExampleForBeforeMurder1 = new DialogRegularConvo();
            ExampleForBeforeMurder1.NPCTalking = false;
            ExampleForBeforeMurder1.Text = "Good Evening Mayor.";
            dialogForRegularConvo.Add(ExampleForBeforeMurder1);

            DialogRegularConvo ExampleForBeforeMurder2 = new DialogRegularConvo();
            ExampleForBeforeMurder2.NPCTalking = true;
            ExampleForBeforeMurder2.Text = "Good Evening Ms. Hunt.";
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
        ExampleInterrogationConvo.Question2.QuestionText = "Who would do this to Nikki?";
        ExampleInterrogationConvo.Question2.NextElementNumber = 6;

        ExampleInterrogationConvo.Question3 = new Question();
        ExampleInterrogationConvo.Question3.QuestionText = " "; /*Add something to do with how he runs the town*/
        ExampleInterrogationConvo.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo);

        //Element 1

        DialogueForInterrogation ExampleInterrogationConvo1 = new DialogueForInterrogation();
        ExampleInterrogationConvo1.NextElementNumber = 1;
        ExampleInterrogationConvo1.NPCTalking = true;
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
        ExampleInterrogationConvo2.NPCTalking = true;
        ExampleInterrogationConvo2.EndInterrogation = false;
        ExampleInterrogationConvo2.NoQuestions = false;
        ExampleInterrogationConvo2.Response = "I had thought it might be thunder.";
        //Creating a Question

        ExampleInterrogationConvo2.Question1 = new Question();
        ExampleInterrogationConvo2.Question1.QuestionText = "Interesting [Back to the first screen]";
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
        ExampleInterrogationConvo3.NPCTalking = true;
        ExampleInterrogationConvo3.EndInterrogation = false;
        ExampleInterrogationConvo3.NoQuestions = false;
        ExampleInterrogationConvo3.Response = "I did see Mirianne, but she was a bit further down the hall and walking away from the lab.";
        //Creating a Question

        ExampleInterrogationConvo3.Question1 = new Question();
        ExampleInterrogationConvo3.Question1.QuestionText = "Very interesting [Back to the first screen]";
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
        ExampleInterrogationConvo5.NPCTalking = true;
        ExampleInterrogationConvo5.EndInterrogation = false;
        ExampleInterrogationConvo5.NoQuestions = false;
        ExampleInterrogationConvo5.Response = "It might do us some good to look for them.";
        //Creating a Question

        ExampleInterrogationConvo5.Question1 = new Question();
        ExampleInterrogationConvo5.Question1.QuestionText = "Indeed [Back to the first screen]";
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
        ExampleInterrogationConvo6.Response = "Your guess is as good as mine, but whomever it was, this does not bode well for my re-election campaign!";
        //Creating a Question

        ExampleInterrogationConvo6.Question1 = new Question();
        ExampleInterrogationConvo6.Question1.QuestionText = "How do you mean?";
        ExampleInterrogationConvo6.Question1.NextElementNumber = 7;

        ExampleInterrogationConvo6.Question2 = new Question();
        ExampleInterrogationConvo6.Question2.QuestionText = "Your campaign? My friend was murdered!";
        ExampleInterrogationConvo6.Question2.NextElementNumber = 11;

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
        ExampleInterrogationConvo7.Response = "Well, I can see the headlines now... 'Mysterious Mansion Murder, Misfit Mayor Mystified!'. The papers are going to have a field day with this!";
        //Creating a Question

        ExampleInterrogationConvo7.Question1 = new Question();
        ExampleInterrogationConvo7.Question1.QuestionText = "Don't worry Sir, I'm going to get to the bottom of this!";
        ExampleInterrogationConvo7.Question1.NextElementNumber = 8;

        ExampleInterrogationConvo7.Question2 = new Question();
        ExampleInterrogationConvo7.Question2.QuestionText = "*muttering to herself* Well perhaps if you made good on your campaign promises and actually put money into developing the city, rather than-";
        ExampleInterrogationConvo7.Question2.NextElementNumber = 9;

        ExampleInterrogationConvo7.Question3 = new Question();
        ExampleInterrogationConvo7.Question3.QuestionText = "A bit overboard with the alliteration, don't you think?";
        ExampleInterrogationConvo7.Question3.NextElementNumber = 10;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo7);

        //Element 8

        DialogueForInterrogation ExampleInterrogationConvo8 = new DialogueForInterrogation();
        ExampleInterrogationConvo8.NextElementNumber = 1;
        ExampleInterrogationConvo8.NPCTalking = true;
        ExampleInterrogationConvo8.EndInterrogation = false;
        ExampleInterrogationConvo8.NoQuestions = false;
        ExampleInterrogationConvo8.Response = "*Hrmph* If you say so...";
        //Creating a Question

        ExampleInterrogationConvo8.Question1 = new Question();
        ExampleInterrogationConvo8.Question1.QuestionText = "Oh ye of little faith... [Back to the first screen]";
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
        ExampleInterrogationConvo9.Response = "What was that?!";
        //Creating a Question

        ExampleInterrogationConvo9.Question1 = new Question();
        ExampleInterrogationConvo9.Question1.QuestionText = "*coughs* Nothing! [Back to the first screen]";
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
        ExampleInterrogationConvo10.Response = "Nonsense! Noonly News Never Knows Nothing!";
        //Creating a Question

        ExampleInterrogationConvo10.Question1 = new Question();
        ExampleInterrogationConvo10.Question1.QuestionText = "... [Back to the first screen]";
        ExampleInterrogationConvo10.Question1.NextElementNumber = 0;

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
        ExampleInterrogationConvo11.Response = "Sorry my dear... I ... I don't know why I said that.";
        //Creating a Question

        ExampleInterrogationConvo11.Question1 = new Question();
        ExampleInterrogationConvo11.Question1.QuestionText = "Never mind, let's get back on track [Back to the first screen]";
        ExampleInterrogationConvo11.Question1.NextElementNumber = 0;

        ExampleInterrogationConvo11.Question2 = new Question();
        ExampleInterrogationConvo11.Question2.QuestionText = " ";
        ExampleInterrogationConvo11.Question2.NextElementNumber = 0;

        ExampleInterrogationConvo11.Question3 = new Question();
        ExampleInterrogationConvo11.Question3.QuestionText = " ";
        ExampleInterrogationConvo11.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo11);
    }

    public override void SetAfterClueConvo()
    {
        base.SetAfterClueConvo();
        DialogueAfterClue ExampledialogueAfterClue = new DialogueAfterClue();
        ExampledialogueAfterClue.CorrectClue = false;
        ExampledialogueAfterClue.EndInterrogation = false;
        ExampledialogueAfterClue.NoQuestions = true;
        ExampledialogueAfterClue.NPCTalking = true;
        ExampledialogueAfterClue.Response = " I don't know what that is [It seems this is not the right clue for Frederick...]";
        DialogueAfterClues.Add(ExampledialogueAfterClue);

        //Right Clue Dialogue
        //Element 1
        DialogueAfterClue ExampledialogueAfterClue1 = new DialogueAfterClue();
        ExampledialogueAfterClue1.CorrectClue = true;
        ExampledialogueAfterClue1.EndInterrogation = false;
        ExampledialogueAfterClue1.NoQuestions = false;
        ExampledialogueAfterClue1.NPCTalking = true;
        ExampledialogueAfterClue1.Response = " Ah, you found them! Excellent.";
        //DialogueAfterClues.Add(ExampledialogueAfterClue1);

        //Creating a Question

        ExampledialogueAfterClue1.Question1 = new Question();
        ExampledialogueAfterClue1.Question1.QuestionText = "Yes, now if only we knew who tried to hide them!";
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
        ExampledialogueAfterClue2.Response = "Yes. I must say, the toilet was a very strange place to try to hide them.";
        //DialogueAfterClues.Add(ExampledialogueAfterClue2);

        //Creating a Question

        ExampledialogueAfterClue2.Question1 = new Question();
        ExampledialogueAfterClue2.Question1.QuestionText = "It was... Wait a minute. I never mentioned where I'd found the keys... How did you know they were in the toilet stall?";
        ExampledialogueAfterClue2.Question1.NextElementNumber = 3;

        ExampledialogueAfterClue2.Question2 = new Question();
        ExampledialogueAfterClue2.Question2.QuestionText = "It's a shame John and his Dad weren't able to see who was in the next stall";
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
        ExampledialogueAfterClue3.Response = "*coughs* If I recall, I believe I had heard that fellow Jayson mention seeing a pair of keys in the toilet stall.";
       // DialogueAfterClues.Add(ExampledialogueAfterClue3);

        //Creating a Question

        ExampledialogueAfterClue3.Question1 = new Question();
        ExampledialogueAfterClue3.Question1.QuestionText = "You don't say... Now that I think about it, how did you know the keys were missing in the first place? ";
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
        ExampledialogueAfterClue4.Response = "*stuttering* My dear, why does any of this matter? We have the keys, that's the important thing!";
        // DialogueAfterClues.Add(ExampledialogueAfterClue3);

        //Creating a Question

        ExampledialogueAfterClue4.Question1 = new Question();
        ExampledialogueAfterClue4.Question1.QuestionText = "Indeed... ";
        ExampledialogueAfterClue4.Question1.NextElementNumber = 5;

        ExampledialogueAfterClue4.Question2 = new Question();
        ExampledialogueAfterClue4.Question2.QuestionText = "Don't forget, we need to figure out who took they keys in the first place! ";
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
        ExampledialogueAfterClue5.Response = "I think I should hold on to them, just in case...";
        // DialogueAfterClues.Add(ExampledialogueAfterClue3);

        //Creating a Question

        ExampledialogueAfterClue5.Question1 = new Question();
        ExampledialogueAfterClue5.Question1.QuestionText = "No, I think I'll hang on to them... [Back to the first screen]";
        ExampledialogueAfterClue5.Question1.NextElementNumber = 1;

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
        ExampledialogueAfterClue6.EndInterrogation = false;
        ExampledialogueAfterClue6.NoQuestions = false;
        ExampledialogueAfterClue6.NPCTalking = true;
        ExampledialogueAfterClue6.Response = "A-Ah yes, of course!";
        // DialogueAfterClues.Add(ExampledialogueAfterClue3);

        //Creating a Question

        ExampledialogueAfterClue6.Question1 = new Question();
        ExampledialogueAfterClue6.Question1.QuestionText = "[Back to first screen]";
        ExampledialogueAfterClue6.Question1.NextElementNumber = 1;

        ExampledialogueAfterClue6.Question2 = new Question();
        ExampledialogueAfterClue6.Question2.QuestionText = " ";
        ExampledialogueAfterClue6.Question2.NextElementNumber = 0;

        ExampledialogueAfterClue6.Question3 = new Question();
        ExampledialogueAfterClue6.Question3.QuestionText = " ";
        ExampledialogueAfterClue6.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueAfterClues.Add(ExampledialogueAfterClue6);

        //Element 7
        DialogueAfterClue ExampledialogueAfterClue7 = new DialogueAfterClue();
        ExampledialogueAfterClue7.CorrectClue = true;
        ExampledialogueAfterClue7.EndInterrogation = false;
        ExampledialogueAfterClue7.NoQuestions = false;
        ExampledialogueAfterClue7.NPCTalking = true;
        ExampledialogueAfterClue7.Response = "There were TWO people in that stall?? ";
        // DialogueAfterClues.Add(ExampledialogueAfterClue3);

        //Creating a Question

        ExampledialogueAfterClue7.Question1 = new Question();
        ExampledialogueAfterClue7.Question1.QuestionText = "Don't ask... [Back to the first screen]";
        ExampledialogueAfterClue7.Question1.NextElementNumber = 1;

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
 Potential Dialogue  

---------
*/
