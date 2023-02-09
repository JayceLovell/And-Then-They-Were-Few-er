using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootPrint : Objects
{
    public Clue clue;

    public override void Use()
    {
        base.Use();
        if (!ClueManager.clueManager.clues.Contains(clue))
        {
            SoundManager.PlaySound(SoundManager.SoundFX.Clue);

            ClueManager.clueManager.AddClue(clue);
        }
    }
}
