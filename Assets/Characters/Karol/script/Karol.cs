using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Karol : Character
{
    public override void SetRegularConvo()
    {
        base.SetRegularConvo();
        if (GameManager.Instance.PlayerProgress == GameManager.GameState.BeforeMurder)
        {
            DialogRegularConvo ExampleForBeforeMurder = new DialogRegularConvo();
            ExampleForBeforeMurder.NPCTalking = true;
            ExampleForBeforeMurder.Text = "(The eccentric and egotistical rival inventor to Nikki Test. She is sponsored by Mirianne)";
            dialogForRegularConvo.Add(ExampleForBeforeMurder);

            DialogRegularConvo ExampleForBeforeMurder1 = new DialogRegularConvo();
            ExampleForBeforeMurder1.NPCTalking = false;
            ExampleForBeforeMurder1.Text = "Hello, I'm Ashlyn. Nice to meet you.";
            dialogForRegularConvo.Add(ExampleForBeforeMurder1);

            DialogRegularConvo ExampleForBeforeMurder2 = new DialogRegularConvo();
            ExampleForBeforeMurder2.NPCTalking = true;
            ExampleForBeforeMurder2.Text = "Hello yes, I am Karol. Inventor extraordinaire! I'm sure you've heard all about me.";
            dialogForRegularConvo.Add(ExampleForBeforeMurder2);

            DialogRegularConvo ExampleForBeforeMurder3 = new DialogRegularConvo();
            ExampleForBeforeMurder3.NPCTalking = false;
            ExampleForBeforeMurder3.Text = "Uh... no sorry, can't say I have.";
            dialogForRegularConvo.Add(ExampleForBeforeMurder3);

            DialogRegularConvo ExampleForBeforeMurder4 = new DialogRegularConvo();
            ExampleForBeforeMurder4.NPCTalking = true;
            ExampleForBeforeMurder4.Text = "(Karol looks disappointed)";
            dialogForRegularConvo.Add(ExampleForBeforeMurder4);

            DialogRegularConvo ExampleForBeforeMurder5 = new DialogRegularConvo();
            ExampleForBeforeMurder5.NPCTalking = true;
            ExampleForBeforeMurder5.Text = "Oh...";
            dialogForRegularConvo.Add(ExampleForBeforeMurder5);

            DialogRegularConvo ExampleForBeforeMurder6 = new DialogRegularConvo();
            ExampleForBeforeMurder6.NPCTalking = true;
            ExampleForBeforeMurder6.Text = " W-well, I guess you can't expect a detective such as yourself to be plugged into the world of inventing.";
            dialogForRegularConvo.Add(ExampleForBeforeMurder6);

            DialogRegularConvo ExampleForBeforeMurder7 = new DialogRegularConvo();
            ExampleForBeforeMurder7.NPCTalking = true;
            ExampleForBeforeMurder7.Text = "I'll be taking the place of Nikki as the most prolific inventor in Wandermere soon enough.";
            dialogForRegularConvo.Add(ExampleForBeforeMurder7);

            DialogRegularConvo ExampleForBeforeMurder8 = new DialogRegularConvo();
            ExampleForBeforeMurder8.NPCTalking = true;
            ExampleForBeforeMurder8.Text = "Once my latest invention is complete you'll be hearing my name uttered from the lips of everyone in town.";
            dialogForRegularConvo.Add(ExampleForBeforeMurder8);

            DialogRegularConvo ExampleForBeforeMurder9 = new DialogRegularConvo();
            ExampleForBeforeMurder9.NPCTalking = false;
            ExampleForBeforeMurder9.Text = "Well if you say so. Good luck� I guess.";
            dialogForRegularConvo.Add(ExampleForBeforeMurder9);
        }
        else
        {

            DialogRegularConvo ExampleForAfterMurder = new DialogRegularConvo();
            ExampleForAfterMurder.NPCTalking = true;
            ExampleForAfterMurder.Text = "With the atmosphere in here, and the storm out there, this has turned into quite a depressing night.";
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
        ExampleInterrogationConvo.Question2.QuestionText = "I know you were rivals, but surely you and Nikki would have stood to gain more by collaborating?";
        ExampleInterrogationConvo.Question2.NextElementNumber = 6;

        ExampleInterrogationConvo.Question3 = new Question();
        ExampleInterrogationConvo.Question3.QuestionText = "You know, I'm a bit embarassed that I didn't know of you, when we chatted earlier. Tell me about yourself.  ";
        ExampleInterrogationConvo.Question3.NextElementNumber = 5;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo);

        //Element 1

        DialogueForInterrogation ExampleInterrogationConvo1 = new DialogueForInterrogation();
        ExampleInterrogationConvo1.NextElementNumber = 1;
        ExampleInterrogationConvo1.NPCTalking = true;
        ExampleInterrogationConvo1.EndInterrogation = false;
        ExampleInterrogationConvo1.NoQuestions = false;
        ExampleInterrogationConvo1.Response = "I was in my room. I couldn't sleep of course.";
        //Creating a Question

        ExampleInterrogationConvo1.Question1 = new Question();
        ExampleInterrogationConvo1.Question1.QuestionText = "Oh? And why was that?";
        ExampleInterrogationConvo1.Question1.NextElementNumber = 2;

        ExampleInterrogationConvo1.Question2 = new Question();
        ExampleInterrogationConvo1.Question2.QuestionText = "[Back to the first screen] ";
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
        ExampleInterrogationConvo2.Response = "Nikki's Synthesizer! I hate to say it, but it's the most amazing technology I've ever seen!" +
            "My brain could just not stop thinking of way's to one up her designs." +
            "It's a shame that now she's gone, it might never see the light of day�";
        //Creating a Question

        ExampleInterrogationConvo2.Question1 = new Question();
        ExampleInterrogationConvo2.Question1.QuestionText = "But I suppose that now Nikki is gone, you should have no competition left in Wandermere eh?  ";
        ExampleInterrogationConvo2.Question1.NextElementNumber = 3;

        ExampleInterrogationConvo2.Question2 = new Question();
        ExampleInterrogationConvo2.Question2.QuestionText = "[Back to the first screen] ";
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
        ExampleInterrogationConvo3.Response = "What are you trying to say Detective?" +
            "Are you trying to suggest that it was me who killed Nikki? That's a heavy accusation!";
        //Creating a Question

        ExampleInterrogationConvo3.Question1 = new Question();
        ExampleInterrogationConvo3.Question1.QuestionText = "If the glove fits...";
        ExampleInterrogationConvo3.Question1.NextElementNumber = 4;

        ExampleInterrogationConvo3.Question2 = new Question();
        ExampleInterrogationConvo3.Question2.QuestionText = "[Back to the first screen] ";
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
        ExampleInterrogationConvo4.NoQuestions = true;
        ExampleInterrogationConvo4.Response = " Now, Nikki and I may have been rivals, but I still had respect for her! " +
            "If anything I'd want her to still be alive, to witness me surpass her!"/* +
            "If you want someone to suspect, Detective, I'd suggest looking into Mr. Damien. " +
            "I heard Nikki was thinking of firing him, maybe he felt threatened."*/;



        //Creating a Question

        ExampleInterrogationConvo4.Question1 = new Question();
        ExampleInterrogationConvo4.Question1.QuestionText = "Hm... [Back to the first screen]";
        ExampleInterrogationConvo4.Question1.NextElementNumber = 0;

        ExampleInterrogationConvo4.Question2 = new Question();
        ExampleInterrogationConvo4.Question2.QuestionText = "[Back to the first screen] ";
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
        ExampleInterrogationConvo5.Response = "Oh! Well, I'm a graduate of the Adrian Institute. I studied under the great professor Javier, and I'm a three time winner of the Jayce award for excellence!";
        //Creating a Question

        ExampleInterrogationConvo5.Question1 = new Question();
        ExampleInterrogationConvo5.Question1.QuestionText = " Okay, I think I know enough now... [Back to the first screen]";
        ExampleInterrogationConvo5.Question1.NextElementNumber = 0;

        ExampleInterrogationConvo5.Question2 = new Question();
        ExampleInterrogationConvo5.Question2.QuestionText = "[Back to the first screen]" /*"The Jayce Award! What did you do to earn that?"*/;
        ExampleInterrogationConvo5.Question2.NextElementNumber = 6;

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
        ExampleInterrogationConvo6.Response = "With her? Never! I know Damien would love that, but the thought of working with someone with her background.... ";
        //Creating a Question

        ExampleInterrogationConvo6.Question1 = new Question();
        ExampleInterrogationConvo6.Question1.QuestionText = "Her background...? ";
        ExampleInterrogationConvo6.Question1.NextElementNumber = 7;

        ExampleInterrogationConvo6.Question2 = new Question();
        ExampleInterrogationConvo6.Question2.QuestionText = "Damien? You and Damien are acquainted? ";
        ExampleInterrogationConvo6.Question2.NextElementNumber = 9;

        ExampleInterrogationConvo6.Question3 = new Question();
        ExampleInterrogationConvo6.Question3.QuestionText = "[Back to the first screen] ";
        ExampleInterrogationConvo6.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo6);
		
		//Element 7

        DialogueForInterrogation ExampleInterrogationConvo7 = new DialogueForInterrogation();
        ExampleInterrogationConvo7.NextElementNumber = 1;
        ExampleInterrogationConvo7.NPCTalking = true;
        ExampleInterrogationConvo7.EndInterrogation = false;
        ExampleInterrogationConvo7.NoQuestions = false;
        ExampleInterrogationConvo7.Response = " *ahem* Well, what prestigious school's did she go to? Who is her sponsor?";
        //Creating a Question

        ExampleInterrogationConvo7.Question1 = new Question();
        ExampleInterrogationConvo7.Question1.QuestionText = "Hey, Nikki may not have gone to your fancy school, but she worked her butt off to get to where she is. And she's still a genius.";
        ExampleInterrogationConvo7.Question1.NextElementNumber = 8;

        ExampleInterrogationConvo7.Question2 = new Question();
        ExampleInterrogationConvo7.Question2.QuestionText = "[Back to the first screen] ";
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
        ExampleInterrogationConvo8.Response = "If you say so...";
        //Creating a Question

        ExampleInterrogationConvo8.Question1 = new Question();
        ExampleInterrogationConvo8.Question1.QuestionText = "Hm! [Back to the first screen]";
        ExampleInterrogationConvo8.Question1.NextElementNumber = 0;

        ExampleInterrogationConvo8.Question2 = new Question();
        ExampleInterrogationConvo8.Question2.QuestionText = "[Back to the first screen] ";
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
        ExampleInterrogationConvo9.Response = "Never you mind!";
        //Creating a Question

        ExampleInterrogationConvo9.Question1 = new Question();
        ExampleInterrogationConvo9.Question1.QuestionText = "(Thinking to herself) It seems I might need something more to get her to open up about Damien [Back to the first screen]";
        ExampleInterrogationConvo9.Question1.NextElementNumber = 0;

        ExampleInterrogationConvo9.Question2 = new Question();
        ExampleInterrogationConvo9.Question2.QuestionText = "[Back to the first screen] ";
        ExampleInterrogationConvo9.Question2.NextElementNumber = 0;

        ExampleInterrogationConvo9.Question3 = new Question();
        ExampleInterrogationConvo9.Question3.QuestionText = " ";
        ExampleInterrogationConvo9.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo9);

        
    }

    public override void SetAfterClueConvo()
    {
        base.SetAfterClueConvo();
        DialogueAfterClue ExampledialogueAfterClue = new DialogueAfterClue();
        ExampledialogueAfterClue.CorrectClue = false;
        ExampledialogueAfterClue.EndInterrogation = false;
        ExampledialogueAfterClue.NoQuestions = true;
        ExampledialogueAfterClue.NPCTalking = true;
        ExampledialogueAfterClue.Response = " *Looks confused* [It seems this is not the right clue for Karol...]";
        DialogueAfterClues.Add(ExampledialogueAfterClue);

        //Right Clue Dialogue
        //Element 1
        DialogueAfterClue ExampledialogueAfterClue1 = new DialogueAfterClue();
        ExampledialogueAfterClue1.CorrectClue = true;
        ExampledialogueAfterClue1.EndInterrogation = false;
        ExampledialogueAfterClue1.NoQuestions = false;
        ExampledialogueAfterClue1.NPCTalking = true;
        ExampledialogueAfterClue1.Response = "I-I don't know what that is.";
        //DialogueAfterClues.Add(ExampledialogueAfterClue1);

        //Creating a Question

        ExampledialogueAfterClue1.Question1 = new Question();
        ExampledialogueAfterClue1.Question1.QuestionText = "Really? It seems to be addressed to you...";
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
        ExampledialogueAfterClue2.Response = "*covers face with hands*";
        //DialogueAfterClues.Add(ExampledialogueAfterClue1);

        //Creating a Question

        ExampledialogueAfterClue2.Question1 = new Question();
        ExampledialogueAfterClue2.Question1.QuestionText = "Now, the truth please";
        ExampledialogueAfterClue2.Question1.NextElementNumber = 3;

        ExampledialogueAfterClue2.Question2 = new Question();
        ExampledialogueAfterClue2.Question2.QuestionText = "[Back to the first screen] ";
        ExampledialogueAfterClue2.Question2.NextElementNumber = 0;

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
        ExampledialogueAfterClue3.Response = "It was sent to me by Damien.";
        //DialogueAfterClues.Add(ExampledialogueAfterClue1);

        //Creating a Question

        ExampledialogueAfterClue3.Question1 = new Question();
        ExampledialogueAfterClue3.Question1.QuestionText = "Why would Damien be writing to you?";
        ExampledialogueAfterClue3.Question1.NextElementNumber = 4;

        ExampledialogueAfterClue3.Question2 = new Question();
        ExampledialogueAfterClue3.Question2.QuestionText = "[Back to the first screen] ";
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
        ExampledialogueAfterClue4.Response = "Him and I have an ongoing... er... 'entanglement', and it seems he wanted to re-negotiate the terms of our contract.";
        //DialogueAfterClues.Add(ExampledialogueAfterClue1);

        //Creating a Question

        ExampledialogueAfterClue4.Question1 = new Question();
        ExampledialogueAfterClue4.Question1.QuestionText = "So basically y'all were hooking up and he wanted to end things?";
        ExampledialogueAfterClue4.Question1.NextElementNumber = 5;

        ExampledialogueAfterClue4.Question2 = new Question();
        ExampledialogueAfterClue4.Question2.QuestionText = "Ah, and where did you meetup to discuss your 'contract'?";
        ExampledialogueAfterClue4.Question2.NextElementNumber = 6;

        ExampledialogueAfterClue4.Question3 = new Question();
        ExampledialogueAfterClue4.Question3.QuestionText = "[Back to the first screen] ";
        ExampledialogueAfterClue4.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueAfterClues.Add(ExampledialogueAfterClue4);

        //Element 5
        DialogueAfterClue ExampledialogueAfterClue5 = new DialogueAfterClue();
        ExampledialogueAfterClue5.CorrectClue = true;
        ExampledialogueAfterClue5.EndInterrogation = false;
        ExampledialogueAfterClue5.NoQuestions = false;
        ExampledialogueAfterClue5.NPCTalking = true;
        ExampledialogueAfterClue5.Response = "*Scowls*";
        //DialogueAfterClues.Add(ExampledialogueAfterClue1);

        //Creating a Question

        ExampledialogueAfterClue5.Question1 = new Question();
        ExampledialogueAfterClue5.Question1.QuestionText = "[Previous Screen] ";
        ExampledialogueAfterClue5.Question1.NextElementNumber = 4;

        ExampledialogueAfterClue5.Question2 = new Question();
        ExampledialogueAfterClue5.Question2.QuestionText = "[Back to the first screen] ";
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
        ExampledialogueAfterClue6.Response = "We met in the study.";
        //DialogueAfterClues.Add(ExampledialogueAfterClue1);

        //Creating a Question

        ExampledialogueAfterClue6.Question1 = new Question();
        ExampledialogueAfterClue6.Question1.QuestionText = "Why did you lie to me earlier about being in your room?";
        ExampledialogueAfterClue6.Question1.NextElementNumber = 7;

        ExampledialogueAfterClue6.Question2 = new Question();
        ExampledialogueAfterClue6.Question2.QuestionText = "[Back to the first screen] ";
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
        ExampledialogueAfterClue7.Response = "I didn't lie! I just left out the part about me leaving afterwards to go meet Damien in the study.";
        //DialogueAfterClues.Add(ExampledialogueAfterClue1);

        //Creating a Question

        ExampledialogueAfterClue7.Question1 = new Question();
        ExampledialogueAfterClue7.Question1.QuestionText = "*raises eyebrow* Mm hmm...";
        ExampledialogueAfterClue7.Question1.NextElementNumber = 8;

        ExampledialogueAfterClue7.Question2 = new Question();
        ExampledialogueAfterClue7.Question2.QuestionText = "[Back to the first screen] ";
        ExampledialogueAfterClue7.Question2.NextElementNumber = 0;

        ExampledialogueAfterClue7.Question3 = new Question();
        ExampledialogueAfterClue7.Question3.QuestionText = " ";
        ExampledialogueAfterClue7.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueAfterClues.Add(ExampledialogueAfterClue7);

        //Element 8
        DialogueAfterClue ExampledialogueAfterClue8 = new DialogueAfterClue();
        ExampledialogueAfterClue8.CorrectClue = true;
        ExampledialogueAfterClue8.EndInterrogation = false;
        ExampledialogueAfterClue8.NoQuestions = true;
        ExampledialogueAfterClue8.NPCTalking = true;
        ExampledialogueAfterClue8.Response = "Well, needless to say, negotiations are still ongoing!";
        //DialogueAfterClues.Add(ExampledialogueAfterClue1);

        //Creating a Question

        ExampledialogueAfterClue8.Question1 = new Question();
        ExampledialogueAfterClue8.Question1.QuestionText = " "; //*chokes* [Back to the first screen]
        ExampledialogueAfterClue8.Question1.NextElementNumber = 0;

        ExampledialogueAfterClue8.Question2 = new Question();
        ExampledialogueAfterClue8.Question2.QuestionText = " ";
        ExampledialogueAfterClue8.Question2.NextElementNumber = 0;

        ExampledialogueAfterClue8.Question3 = new Question();
        ExampledialogueAfterClue8.Question3.QuestionText = " ";
        ExampledialogueAfterClue8.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueAfterClues.Add(ExampledialogueAfterClue8);

    }
}

/* 
 Potential Dialogue  
 Maybe some dialogue after Damien reveals to Nikki that him and Karol were together

    Maybe even have Karol say something that damien says about the synthesizer, to clue ashlyn in


*/
