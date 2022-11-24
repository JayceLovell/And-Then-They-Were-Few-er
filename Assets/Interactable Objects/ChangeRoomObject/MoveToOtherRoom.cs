using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToOtherRoom : Objects
{
    public GameController controller;
    public string NameOfRoom;
    void Start()
    {
        controller = GameObject.Find("GameController").GetComponent<GameController>();
    }
    public override void Use()
    {
        base.Use();
        controller.MoveToScene(NameOfRoom);
    }
}
