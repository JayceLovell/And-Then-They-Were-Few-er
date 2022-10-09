using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour
{
    public InputAction StartGame;

    // Start is called before the first frame update
    void Start()
    {
        StartGame.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if (StartGame.IsPressed())
        {
            SceneManager.LoadScene("Game");
        }
    }
}
