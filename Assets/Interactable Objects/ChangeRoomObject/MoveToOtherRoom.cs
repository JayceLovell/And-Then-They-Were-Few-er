using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToOtherRoom : Objects
{
    public string NameOfRoom;

    public override void Use()
    {
        base.Use();
        //Story Guide
        if (_gameController.GameManager.CurrentGameProgress == 1)
        {
            _gameController.MoveToScene("Text");
        }
        else
            _gameController.MoveToScene(NameOfRoom);

    }
}
