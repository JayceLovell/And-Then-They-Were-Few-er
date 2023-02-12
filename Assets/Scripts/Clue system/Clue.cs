using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Statement", menuName = "Statement Asset/Statement")]
public class Clue : ScriptableObject
{
    public string ClueText;
    public bool PickedUp;
}
