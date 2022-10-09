using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{

    bool _playerInteracts;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (_playerInteracts == true)
        { 
            _playerInteracts = false;
        }
    }

    public void SetPlayerInteraction(bool Interacts)
    {
        _playerInteracts = Interacts;
    }
}
