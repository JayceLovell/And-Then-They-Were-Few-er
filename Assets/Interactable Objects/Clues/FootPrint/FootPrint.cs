using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootPrint : Objects
{

    public override void Use()
    {
        base.Use();
        SoundManager.PlaySound(SoundManager.SoundFX.Clue);
    }
}
