using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class TextController : MonoBehaviour
{
    private GameManager GameManager;

    public List<TextMeshProUGUI> text;

    void Awake()
    {
        GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(text[GameManager.CurrentPlayText],GameObject.Find("Canvas").transform);        
    }
    public void OnNext()
    {
        GameManager.SaveScene();
        switch (GameManager.CurrentPlayText)
        {
            case 1:
                GameManager.CurrentPlayText++;
                Destroy(GameObject.Find("After Intro 1(Clone)"));
                Instantiate(text[GameManager.CurrentPlayText], GameObject.Find("Canvas").transform);
                break;
            case 2:
                GameManager.CurrentPlayText++;
                Destroy(GameObject.Find("After Intro 2(Clone)"));                
                Instantiate(text[GameManager.CurrentPlayText], GameObject.Find("Canvas").transform);
                break;
            case 3:
                GameManager.CurrentPlayText++;
                Destroy(GameObject.Find("Body Discovery 1(Clone)"));
                Instantiate(text[GameManager.CurrentPlayText], GameObject.Find("Canvas").transform);
                break;
            case 4:
                GameManager.CurrentPlayText++;
                Destroy(GameObject.Find("Body Discovery 2(Clone)"));
                Instantiate(text[GameManager.CurrentPlayText], GameObject.Find("Canvas").transform);
                break;
            case 5:
                GameManager.CurrentPlayText = 5;
                SceneManager.LoadScene("Grandhall");
                break;
            default:
                GameManager.CurrentPlayText++;
                SceneManager.LoadScene("Entrance");
                break;
        }
    }
}
