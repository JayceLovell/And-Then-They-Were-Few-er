using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToOtherRoom : Objects
{
    public string NameOfRoom;
    private SoundBGVolume soundBGVolume;

    public override void Use()
    {        
        base.Use();
        soundBGVolume = GameObject.FindObjectOfType<SoundBGVolume>();
        soundBGVolume.LowerVolume(1f);
        StartCoroutine(littleWaitBefore());
    }
    IEnumerator littleWaitBefore()
    {
        yield return new WaitForSeconds(2);
        //Story Guide
        if (_gameController._gameManager.CurrentGameProgress == 1)
        {
            _gameController.MoveToScene("Text");
        }
        else
        {
            _gameController.MoveToScene(NameOfRoom);
        }
    }
}
