using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretBookShelf : Objects
{
    Animator Animator;

    private void Start()
    {
        Animator = GetComponent<Animator>();
    }
    public override void Use()
    {
        base.Use();
        Animator.SetBool("Reveal",true);
    }
}
