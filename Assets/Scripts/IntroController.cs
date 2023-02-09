using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroController : MonoBehaviour
{
    public GameManager GameManager;
    public List<TextMeshProUGUI> text;

    void Awake()
    {
        GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(text[GameManager.CurrentPlayText],GameObject.Find("Canvas").transform);
        GameManager.CurrentPlayText++;
    }
    public void ToEntrance()
    {
        GameManager.SaveScene();
        SceneManager.LoadScene("Entrance");
    }
}
