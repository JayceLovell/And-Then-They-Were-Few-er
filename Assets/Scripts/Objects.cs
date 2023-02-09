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
    protected GameController _gameController;

    public DialogueObjectController dialogueObjectController;

    public enum TypeOfObject
    {
        Door,
        Chair,
        Clue,
        Placeholder,
        SecretBookShelf,
        StairsToSecretRoom,
        RoomSwitch,
        PlayerReadyTrigger
    }

    public TypeOfObject objectType;

    public String Dialog;

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
        _gameController = GameObject.Find("GameController").GetComponent<GameController>();
                
        if (GameManager.Instance.CurrentGameProgress <= 3)
            if (objectType == TypeOfObject.Clue)
                this.gameObject.SetActive(false);
        
    }
    /// <summary>
    /// Default class for using an object
    /// </summary>
    public virtual void Use()
    {
        Debug.Log("Action from object: "+objectType.ToString());
  
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
