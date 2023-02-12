using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Karol : Character
{
    void Start()
    {

        //Regular
        //DialogRegularConvo ExampleRegularConvo = new DialogRegularConvo();
        //ExampleRegularConvo.Text = "Example";
        //ExampleRegularConvo.NPCTalking = true;
        //dialogForRegularConvo.Add(ExampleRegularConvo);

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
        ExampleInterrogationConvo1.Response = "I was in my room. I couldn’t sleep of course.";
        //Creating a Question

        ExampleInterrogationConvo1.Question1 = new Question();
        ExampleInterrogationConvo1.Question1.QuestionText = "Oh? And why was that?";
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
        ExampleInterrogationConvo2.Response = "Nikki’s Synthesizer! I hate to say it, but it’s the most amazing technology I’ve ever seen!" +
            "My brain could just not stop thinking of way’s to one up her designs." +
            "It’s a shame that now she’s gone, it might never see the light of day…";
        //Creating a Question

        ExampleInterrogationConvo2.Question1 = new Question();
        ExampleInterrogationConvo2.Question1.QuestionText = " ";
        ExampleInterrogationConvo2.Question1.NextElementNumber = 0;

        ExampleInterrogationConvo2.Question2 = new Question();
        ExampleInterrogationConvo2.Question2.QuestionText = " ";
        ExampleInterrogationConvo2.Question2.NextElementNumber = 0;

        ExampleInterrogationConvo2.Question3 = new Question();
        ExampleInterrogationConvo2.Question3.QuestionText = "But I suppose that now Nikki is gone, you should have no competition left in Wandermere eh? ";
        ExampleInterrogationConvo2.Question3.NextElementNumber = 3;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo2);

        //Element 3

        DialogueForInterrogation ExampleInterrogationConvo3 = new DialogueForInterrogation();
        ExampleInterrogationConvo3.NextElementNumber = 1;
        ExampleInterrogationConvo3.NPCTalking = false;
        ExampleInterrogationConvo3.EndInterrogation = false;
        ExampleInterrogationConvo3.NoQuestions = false;
        ExampleInterrogationConvo3.Response = "What are you trying to say Detective?" +
            "Are you trying to suggest that it was me who killed Nikki? That’s a heavy accusation!";
        //Creating a Question

        ExampleInterrogationConvo3.Question1 = new Question();
        ExampleInterrogationConvo3.Question1.QuestionText = "If the glove fits...";
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
        ExampleInterrogationConvo4.EndInterrogation = false;
        ExampleInterrogationConvo4.NoQuestions = true;
        ExampleInterrogationConvo4.Response = " Now, Nikki and I may have been rivals, but I still had respect for her! " +
            "If anything I’d want her to still be alive, to witness me surpass her!" +
            "If you want someone to suspect, Detective, I’d suggest looking into Mr. Damien. " +
            "I heard Nikki was thinking of firing him, maybe he felt threatened.";

        //Creating a Question

        ExampleInterrogationConvo4.Question1 = new Question();
        ExampleInterrogationConvo4.Question1.QuestionText = " ";
        ExampleInterrogationConvo4.Question1.NextElementNumber = 5;

        ExampleInterrogationConvo4.Question2 = new Question();
        ExampleInterrogationConvo4.Question2.QuestionText = " ";
        ExampleInterrogationConvo4.Question2.NextElementNumber = 0;

        ExampleInterrogationConvo4.Question3 = new Question();
        ExampleInterrogationConvo4.Question3.QuestionText = " ";
        ExampleInterrogationConvo4.Question3.NextElementNumber = 0;
        //Add unique item
        DialogueForInterrogations.Add(ExampleInterrogationConvo4);

        
    }
}

/* 
 Potential Dialogue  
 Maybe some dialogue after Damien reveals to Nikki that him and Karol were together

    Maybe even have Karol say something that damien says about the synthesizer, to clue ashlyn in


*/
