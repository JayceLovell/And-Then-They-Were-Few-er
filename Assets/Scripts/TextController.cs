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
        Instantiate(text[GameManager.CurrentGameProgress],GameObject.Find("Canvas").transform);        
    }
    public void OnNext()
    {
        GameManager.SaveScene();
        switch (GameManager.CurrentGameProgress)
        {
            case 1:
                GameManager.CurrentGameProgress++;
                Destroy(GameObject.Find("After Intro 1(Clone)"));
                Instantiate(text[GameManager.CurrentGameProgress], GameObject.Find("Canvas").transform);
                break;
            case 2:
                GameManager.CurrentGameProgress++;
                Destroy(GameObject.Find("After Intro 2(Clone)"));                
                Instantiate(text[GameManager.CurrentGameProgress], GameObject.Find("Canvas").transform);
                break;
            case 3:
                GameManager.CurrentGameProgress++;
                Destroy(GameObject.Find("Body Discovery 1(Clone)"));
                Instantiate(text[GameManager.CurrentGameProgress], GameObject.Find("Canvas").transform);
                break;
            case 4:
                GameManager.CurrentGameProgress++;
                Destroy(GameObject.Find("Body Discovery 2(Clone)"));
                Instantiate(text[GameManager.CurrentGameProgress], GameObject.Find("Canvas").transform);
                break;
            case 5:
                GameManager.CurrentGameProgress = 5;
                SceneManager.LoadScene("Grandhall");
                break;
            case 6:
            case 7:
                GameManager.CurrentGameProgress = 0;
                SceneManager.LoadScene("Title");
                break;
            default:
                GameManager.CurrentGameProgress++;
                SceneManager.LoadScene("Entrance");
                break;
        }
    }
}
