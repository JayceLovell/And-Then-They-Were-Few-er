using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterrogationController : MonoBehaviour
{

    public DialogueObjectController DialoguePrefab;
    private GameManager _gameManager;
    public Transform Player;
    public Transform Suspect;

    // Start is called before the first frame update
    void Start()
    {
        _gameManager = GameManager.Instance;
        DialoguePrefab = GameObject.Find("DialoguePrefab").GetComponent <DialogueObjectController>();
        DialoguePrefab.InterrigationMode = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
