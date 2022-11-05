using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameManager GameManager;

    public enum WhichScene
    {
        Test,
        Game,
        Entrance,
        GrandHall,
        SecretRoom
    }

    public WhichScene Scene;

    void Awake()
    {
        GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Scene: "+ Scene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
