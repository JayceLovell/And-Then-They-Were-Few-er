using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyring : Objects
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void Use()
    {
        base.Use();
        SoundManager.PlaySound(SoundManager.SoundFX.Clue);
    }
}
