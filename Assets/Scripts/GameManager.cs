using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool _isGameOver;
    private static GameManager _instance;
    public static GameManager Instance { 
        get { 
            if(_instance == null)
            {
                DontDestroyOnLoad(GameManager.Instance);
                Debug.LogError("Game Manager is NULL");
            }
            return _instance; }
    }

    /// <summary>
    /// How many Clues for Game Won
    /// </summary>
    public int GameWinCondition;
    /// <summary>
    /// Will be used to end game
    /// </summary>
    public bool IsGameOver
    {
        get { return _isGameOver; }
        set { _isGameOver = value; }
    }
    public string CurrentScene;

    void Awake()
    {
        _instance = this;
        DontDestroyOnLoad(GameManager.Instance);
    }
    // Start is called before the first frame update
    void Start()
    {
        GameWinCondition = 5;
        IsGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SaveScene()
    {
        CurrentScene = SceneManager.GetActiveScene().name;
        PlayerPrefs.SetString("LastScene", CurrentScene);
        PlayerPrefs.Save();
    }
}
