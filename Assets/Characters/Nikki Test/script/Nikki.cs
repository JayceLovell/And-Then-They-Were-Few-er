using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nikki : Character
{
    public override void SetRegularConvo()
    {
        base.SetRegularConvo();
        if (GameManager.Instance.PlayerProgress==GameManager.GameState.BeforeMurder)
        {
            DialogRegularConvo ExampleForBeforeMurder = new DialogRegularConvo();
            ExampleForBeforeMurder.NPCTalking = true;
            ExampleForBeforeMurder.Text = "(Nikki grew up in an impoverished neighborhood. Her father left when she was young, leaving her with her mother with the family business. Too stubborn to follow her mothers wishes and take on the family business she instead used her intelligence to invent the Synthesizer)";
            dialogForRegularConvo.Add(ExampleForBeforeMurder);

            DialogRegularConvo ExampleForBeforeMurder1 = new DialogRegularConvo();
            ExampleForBeforeMurder1.NPCTalking = false;
            ExampleForBeforeMurder1.Text = "Nikki, long time no see!";
            dialogForRegularConvo.Add(ExampleForBeforeMurder1);

            DialogRegularConvo ExampleForBeforeMurder2 = new DialogRegularConvo();
            ExampleForBeforeMurder2.NPCTalking = true;
            ExampleForBeforeMurder2.Text = "Ashlyn! It’s been so long! I’m so glad you could make it!";
            dialogForRegularConvo.Add(ExampleForBeforeMurder2);

            DialogRegularConvo ExampleForBeforeMurder3 = new DialogRegularConvo();
            ExampleForBeforeMurder3.NPCTalking = false;
            ExampleForBeforeMurder3.Text = "Well, I couldn’t say no to an invitation from an old friend. Quite the fancy to-do you’ve set up.";
            dialogForRegularConvo.Add(ExampleForBeforeMurder3);

            DialogRegularConvo ExampleForBeforeMurder4 = new DialogRegularConvo();
            ExampleForBeforeMurder4.NPCTalking = true;
            ExampleForBeforeMurder4.Text = "Hehe, glad you’re impressed. It takes a lot more effort than you might think to set up one of these. Almost didn’t want to do it but it’d be a shame not to show off my latest invention.";
            dialogForRegularConvo.Add(ExampleForBeforeMurder4);

            DialogRegularConvo ExampleForBeforeMurder5 = new DialogRegularConvo();
            ExampleForBeforeMurder5.NPCTalking = false;
            ExampleForBeforeMurder5.Text = "What is the invention anyway? You never told anyone, did you?";
            dialogForRegularConvo.Add(ExampleForBeforeMurder5);

            DialogRegularConvo ExampleForBeforeMurder6 = new DialogRegularConvo();
            ExampleForBeforeMurder6.NPCTalking = true;
            ExampleForBeforeMurder6.Text = "You’ll just have to wait and see! Can’t spoil the surprise!";
            dialogForRegularConvo.Add(ExampleForBeforeMurder6);
			
			DialogRegularConvo ExampleForBeforeMurder7 = new DialogRegularConvo();
            ExampleForBeforeMurder7.NPCTalking = false;
            ExampleForBeforeMurder7.Text = "*chuckles* Alright. By the way, where did Wattson rush off to? He left right after letting me in, I was hoping to get his insight on this gasket case I've been working";
            dialogForRegularConvo.Add(ExampleForBeforeMurder7);
			
			DialogRegularConvo ExampleForBeforeMurder8 = new DialogRegularConvo();
            ExampleForBeforeMurder8.NPCTalking = true;
            ExampleForBeforeMurder8.Text = "*gives a short laugh* Always on the job, eh?";
            dialogForRegularConvo.Add(ExampleForBeforeMurder8);
			
			DialogRegularConvo ExampleForBeforeMurder9 = new DialogRegularConvo();
            ExampleForBeforeMurder9.NPCTalking = true;
            ExampleForBeforeMurder9.Text = "I'd instructed him to go right back to the lab once everyone was here. Just some final touches in prep for the showcase!";
            dialogForRegularConvo.Add(ExampleForBeforeMurder9);
			
			DialogRegularConvo ExampleForBeforeMurder10 = new DialogRegularConvo();
            ExampleForBeforeMurder10.NPCTalking = false;
            ExampleForBeforeMurder10.Text = "Ah, alright. Perhaps I'll talk to him after the showcase then. ";
            dialogForRegularConvo.Add(ExampleForBeforeMurder10);
			
			DialogRegularConvo ExampleForBeforeMurder11 = new DialogRegularConvo();
            ExampleForBeforeMurder11.NPCTalking = false;
            ExampleForBeforeMurder11.Text = "Well, chow Nikki. I know you're going to kill it tonight!";
            dialogForRegularConvo.Add(ExampleForBeforeMurder11);
        }
        else
        {
            // Create convo after Murder
            DialogRegularConvo ExampleForAfterMurder = new DialogRegularConvo();
            ExampleForAfterMurder.NPCTalking = true;
            ExampleForAfterMurder.Text = "*A Hologram of Nikki, coincidentally standing in the same spot that she was in when she was alive*";
            dialogForRegularConvo.Add(ExampleForAfterMurder);
        }
    }
}
