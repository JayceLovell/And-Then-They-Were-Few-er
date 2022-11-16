using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Object parent class
/// </summary>
public class Objects : MonoBehaviour
{
    private bool _playerInteracts;

    public enum TypeOfObject
    {
        Door,
        Chair,
        ClueType,
        Placeholder
    }

    public TypeOfObject objectType;
    /// <summary>
    /// If player is interacting with object
    /// </summary>
    public bool PlayerInteracts
    {
        get { return _playerInteracts; }
        set
        {
            _playerInteracts = value;
            if (value)
                _playerInteracts = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    /// <summary>
    /// Default class for using an object
    /// </summary>
    public void Use()
    {
        Debug.Log("Action");
        // thinking of putting an output dialog to screen about using the object
    }
    /// <summary>
    /// @DrCatman
    /// describe this method does
    /// </summary>
    /// <param name="Interacts"></param>
    public void SetPlayerInteraction(bool Interacts)
    {
        _playerInteracts = Interacts;
    }
}
