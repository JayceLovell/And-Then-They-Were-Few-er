using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextController : MonoBehaviour
{
    private GameManager _gameManager;

    public List<TextMeshProUGUI> text;

    public List<GameOverText> GameOverTexts;

    public class GameOverText
    {
        public string SelectCharacterName;
        public TextMeshProUGUI text;
    }

    void Awake()
    {
        _gameManager = GameManager.Instance;
    }
    // Start is called before the first frame update
    void Start()
    {
        if(!_gameManager.IsGameOver)
            Instantiate(text[_gameManager.CurrentGameProgress],GameObject.Find("Canvas").transform);
        else
        {

        }
    }
    public void OnNext()
    {
        switch (_gameManager.CurrentGameProgress)
        {
            case 1:
                _gameManager.CurrentGameProgress++;
                Destroy(GameObject.Find("After Intro 1(Clone)"));
                Instantiate(text[_gameManager.CurrentGameProgress], GameObject.Find("Canvas").transform);
                break;
            case 2:
                _gameManager.CurrentGameProgress++;
                Destroy(GameObject.Find("After Intro 2(Clone)"));                
                Instantiate(text[_gameManager.CurrentGameProgress], GameObject.Find("Canvas").transform);
                break;
            case 3:
                _gameManager.CurrentGameProgress++;
                Destroy(GameObject.Find("Body Discovery 1(Clone)"));
                Instantiate(text[_gameManager.CurrentGameProgress], GameObject.Find("Canvas").transform);
                break;
            case 4:
                _gameManager.CurrentGameProgress++;
                Destroy(GameObject.Find("Body Discovery 2(Clone)"));
                Instantiate(text[_gameManager.CurrentGameProgress], GameObject.Find("Canvas").transform);
                break;
            case 5:
                _gameManager.CurrentGameProgress = 5;
                SceneManager.LoadScene("Grandhall");
                break;
            case 6:
            case 7:
                _gameManager.CurrentGameProgress = 0;
                SceneManager.LoadScene("Title");
                PlayerPrefs.DeleteAll();
                break;
            default:
                _gameManager.CurrentGameProgress++;
                SceneManager.LoadScene("Entrance");
                break;
        }
    }
}
