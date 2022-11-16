using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour
{
    public GameManager GameManager;
    void Awake()
    {
        GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
 
    }
    void OnStart()
    {
        SceneManager.LoadScene("Game");
    }
}
