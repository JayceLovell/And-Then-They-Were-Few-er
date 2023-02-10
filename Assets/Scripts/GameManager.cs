using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{


    //900 is 15 mins    
    private float _gameTime = 900;
    private bool _timeStart;
    private bool _isGamePaused;
    private bool _isGameLost;
    private bool _isGameWon;
    private static GameManager _instance;
    private int _currentGameProgress;
    private float _bgmVolume;
    private float _sfxVolume;
    private string _currentScene;
    private string _lastScene;

    /// <summary>
    /// 15 mins count down
    /// </summary>
    public float GameTime
    {
        get
        {
            return _gameTime;
        }
        set
        {
            _gameTime = value;
            if (_gameTime == 0)
                IsGameOver = true;
        }
    }
    /// <summary>
    /// Is game paused...idk how clearly i can explain this
    /// </summary>
    public bool IsGamePaused
    {
        get
        {
            return _isGamePaused;
        }
        set
        {
            _isGamePaused = value;
        }
    }
    /// <summary>
    /// Players current Progress in the game
    /// </summary>
    public int CurrentGameProgress
    {
        get {            
            return _currentGameProgress; 
        }
        set { 
            _currentGameProgress = value;            
        }
    }
    /// <summary>
    /// Background music volume
    /// </summary>
    public float BGMVolume
    {
        get {            
            return (_bgmVolume);
        }
        set { 
            _bgmVolume = value;            
        }
    }
    /// <summary>
    /// Sound effects background volume
    /// </summary>
    public float SFXVolume {
        get
        {         
            return (_sfxVolume);
        }
        set
        {
            _sfxVolume = value;
        } 
    }

    /// <summary>
    /// So don't have to look for gamemaner everytime just use instance
    /// </summary>
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
    /// lost Game
    /// </summary>
    public bool IsGameOver
    {
        get { 
            return _isGameLost; 
        }
        set { 
            _isGameLost = value;
            if(_isGameLost)
            {
                _timeStart = false;
                CurrentGameProgress = 6;
                SceneManager.LoadScene("Text");
            }
        }
    }

    /// <summary>
    /// Game Won
    /// </summary>
    public bool IsGameWon
    {
        get
        {
            return _isGameWon;
        }
        set
        {
            _isGameWon = value;
            if (_isGameWon)
            {
                _timeStart = false;
                CurrentGameProgress = 7;
                SceneManager.LoadScene("Text");
            }
        }
    }

    /// <summary>
    /// The Name of the CurrentScene we are in at runtime
    /// </summary>
    public string CurrentScene
    {
        get
        {
            return _currentScene;
        }        
    }
    /// <summary>
    /// Previous Scene player was in
    /// </summary>
    public string LastScene
    {
        get
        {
            return _lastScene;
        }
        set
        {
            _lastScene = value;
        }
    }

    //CalledFirst
    void OnEnable()
    {
        Debug.Log("GameManager Enabled");
        SceneManager.sceneLoaded += OnSceneLoaded;
        SceneManager.sceneUnloaded += OnSceneUnloaded;
    }
    void Awake()
    {
        _instance = this;
        DontDestroyOnLoad(GameManager.Instance);
    }
    // Start is called before the first frame update
    void Start()
    {
        IsGameOver = false;
        IsGamePaused = false;
        _loadPlayerPrefs();
    }

    // Update is called once per frame
    void Update()
    {
        if (!IsGamePaused)
        {
            if (_timeStart)
            {
                 GameTime -= Time.deltaTime;
            }
        }
    }
    private void _loadPlayerPrefs()
    {
        if ((PlayerPrefs.GetFloat("Sfx Volume") == 0))
            SFXVolume = 50;

        if ((PlayerPrefs.GetFloat("BGM Volume") == 0))
            BGMVolume = 50;
        if (PlayerPrefs.GetFloat("Game Time") <= 0)
            _gameTime = 900;
        else
            _gameTime = PlayerPrefs.GetFloat("Game Time");

        _lastScene = PlayerPrefs.GetString("Last Scene");
        _currentScene = PlayerPrefs.GetString("Current Scene");
        _currentGameProgress = PlayerPrefs.GetInt("Player Progress");

    }
    private void _savePlayerPrefs()
    {
        PlayerPrefs.SetInt("Player Progress", _currentGameProgress);
        PlayerPrefs.SetFloat("BGM Volume", _bgmVolume);
        PlayerPrefs.SetFloat("SFX Volume", _sfxVolume);
        PlayerPrefs.SetFloat("Game Time", _gameTime);
        PlayerPrefs.SetString("Current Scene", _currentScene);
        PlayerPrefs.SetString("Last Scene",_lastScene);

        string cluesJson = JsonUtility.ToJson(ClueManager.Instance.clues);
        PlayerPrefs.SetString("Clues", cluesJson);

        PlayerPrefs.Save();
    }
    /// <summary>
    /// Prepares new Game
    /// </summary>
    public void NewGame()
    {
        PlayerPrefs.DeleteKey("LastScene");
        PlayerPrefs.DeleteKey("Player Progress");
        PlayerPrefs.DeleteKey("Game Time");
        PlayerPrefs.DeleteKey("Last Scene");
        PlayerPrefs.DeleteKey("Current Scene");
        _loadPlayerPrefs();
        StartGame();
    }
    public void StartGame()
    {
        _lastScene = _currentScene;
        if (CurrentGameProgress == 0)
            SceneManager.LoadScene("Text");
        else if (CurrentGameProgress > 5)
            SceneManager.LoadScene("GrandHall");
        else
            SceneManager.LoadScene("Entrance");
    }
    /// <summary>
    /// Calls on sce/summary>
    /// <param name="scene"></param>
    /// <param name="mode"></param>
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        _currentScene = SceneManager.GetActiveScene().name;
        switch (scene.name)
        {
            case "Title":
                SoundManager.StartBackground(SoundManager.BgSound.Title);               
                break;
            case "Text":
                if (CurrentGameProgress == 6)
                    SoundManager.StartBackground(SoundManager.BgSound.GameLost);
                else if (CurrentGameProgress == 7)
                    SoundManager.StartBackground(SoundManager.BgSound.GameWon);
                else
                    SoundManager.StartBackground(SoundManager.BgSound.MainMenu);                
                break;
            case "Entrance":
                SoundManager.StartBackground(SoundManager.BgSound.Background);
                _savePlayerPrefs();
                break;
            case "GrandHall":
                SoundManager.StartBackground(SoundManager.BgSound.Background);
                _timeStart = true;
                _savePlayerPrefs();
                break;
            case "Big Reveal":
                SoundManager.StartBackground(SoundManager.BgSound.BigReveal);
                _savePlayerPrefs();
                break;
            default:
                Debug.Log("Scene - " + scene.name + " Isn't added to Game Manager so no sound is played.");
                break;
        }        
    }
    void OnSceneUnloaded(Scene current)
    {
        _savePlayerPrefs();
    }
    public void LoadInstructions()
    {
        SceneManager.LoadScene("Instructions", LoadSceneMode.Additive);
    }
    public void Quit()
    {
        _lastScene = _currentScene;
        _savePlayerPrefs();
        Application.Quit();
    }
    void OnDisable()
    {
        Debug.Log("GameManger Disable");
        SceneManager.sceneLoaded -= OnSceneLoaded;
        SceneManager.sceneUnloaded -= OnSceneUnloaded;
    }
}
