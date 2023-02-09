using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootPrint : Objects
{

    public override void Use()
    {
        base.Use();
        SoundManager.PlaySound(SoundManager.SoundFX.Clue);

        _dialogueObjectController.Display(true);
        _dialogueObjectController.InterrigationMode = false;
        StartCoroutine(Display());
               
    }
    IEnumerator Display()
    {
        foreach (char c in Dialog.ToCharArray())
        {
            _dialogueObjectController.Text += c;
            yield return new WaitForSeconds(0.02f);
        }
        GameObject.Find("Player").GetComponent<Player>().Talking = false;
    }
}
