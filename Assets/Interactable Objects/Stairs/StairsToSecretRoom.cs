using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairsToSecretRoom : Objects
{
    GameController controller;
    void Start()
    {
        controller = GetComponent<GameController>();
    }
    public virtual void Use()
    {
        controller.MoveToScene("SecretRoom");
    }
}
