using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class PlayerReady : Objects
{
    public string NameOfRoom;
    public override void Use()
    {
        _gameController.MoveToScene(NameOfRoom);
    }
}
