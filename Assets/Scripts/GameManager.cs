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

    public string CurrentScene;

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
        //_musicPlayer = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {
        IsGameOver = false;
        IsGamePaused = false;
        _loadPlayerPrefs();
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

        _currentGameProgress = PlayerPrefs.GetInt("Player Progress");

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
    private void _savePlayerPrefs()
    {
        PlayerPrefs.SetInt("Player Progress", _currentGameProgress);
        PlayerPrefs.SetFloat("BGM Volume", _bgmVolume);
        PlayerPrefs.SetFloat("SFX Volume", _sfxVolume);
        PlayerPrefs.SetFloat("Game Time", _gameTime);

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
        _loadPlayerPrefs();
        StartGame();
    }
    public void StartGame()
    {
        if (CurrentGameProgress == 0)
            SceneManager.LoadScene("Text");
        else if (CurrentGameProgress > 5)
            SceneManager.LoadScene("GrandHall");
        else
            SceneManager.LoadScene("Entrance");
    }
    public void SaveScene()
    {
        CurrentScene = SceneManager.GetActiveScene().name;
        PlayerPrefs.SetString("LastScene", CurrentScene);
        PlayerPrefs.Save();
    }
    /// <summary>
    /// Calls on sce/summary>
    /// <param name="scene"></param>
    /// <param name="mode"></param>
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        SaveScene();        
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
                break;
            case "GrandHall":
                SoundManager.StartBackground(SoundManager.BgSound.Background);

                _timeStart = true;
                break;
            case "Big Reveal":
                SoundManager.StartBackground(SoundManager.BgSound.BigReveal);
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
        Application.Quit();
    }
    void OnDisable()
    {
        Debug.Log("GameManger Disable");
        SceneManager.sceneLoaded -= OnSceneLoaded;
        SceneManager.sceneUnloaded -= OnSceneUnloaded;
    }
}
