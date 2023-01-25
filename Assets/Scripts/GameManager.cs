using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{


    private float _gameTime;
    private bool _timeStart;
    private bool _isGamePaused;
    private bool _isGameLost;
    private bool _isGameWon;
    private static GameManager _instance;
    private int _currentPlayText;
    private float _bgMusicVolume;
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
    public int CurrentPlayText
    {
        get {
            _currentPlayText = PlayerPrefs.GetInt("PlayTextNumber");
            return _currentPlayText; 
        }
        set { 
            _currentPlayText = value;
            PlayerPrefs.SetInt("PlayTextNumber",value);
        }
    }
    public float BGMusicVolume
    {
        get {
            _bgMusicVolume = PlayerPrefs.GetFloat("Background Volume");
            return (_bgMusicVolume / 100);
        }
        set { 
            _bgMusicVolume = value;
            PlayerPrefs.SetFloat("Background Volume", value);
            PlayerPrefs.Save();
        }
    }
    public float SfxVolume {
        get
        {
            _sfxVolume = PlayerPrefs.GetFloat("Sfx Volume");
            return (_sfxVolume / 100);
        }
        set
        {
            _sfxVolume = value;
            PlayerPrefs.SetFloat("Sfx Volume",value);
            PlayerPrefs.Save();
        } 
    }
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
                CurrentPlayText = 6;
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
                CurrentPlayText = 7;
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
        CheckPlayerPrefs();
    }

    private void CheckPlayerPrefs()
    {
        if ((PlayerPrefs.GetInt("PlayTextNumber", 0) == 0))
            CurrentPlayText = 0;
        else
            CurrentPlayText = PlayerPrefs.GetInt("PlayTextNumber");

        if ((PlayerPrefs.GetFloat("Sfx Volume", 0) == 0))
            SfxVolume = 50;

        if ((PlayerPrefs.GetFloat("Background volume", 0) == 0))
            BGMusicVolume = 50;
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
    public void NewGame()
    {
        PlayerPrefs.DeleteKey("LastScene");
        PlayerPrefs.DeleteKey("PlayTextNumber");
        CheckPlayerPrefs();
    }
    public void SaveScene()
    {
        CurrentScene = SceneManager.GetActiveScene().name;
        PlayerPrefs.SetString("LastScene", CurrentScene);
        PlayerPrefs.Save();
    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("Scene Loaded: " + scene.name);
        switch (scene.name)
        {
            case "Title":
                SoundManager.StartBackground(SoundManager.BgSound.Title);
                break;
            case "Text":
                if (CurrentPlayText == 6)
                    SoundManager.StartBackground(SoundManager.BgSound.GameLost);
                else if (CurrentPlayText == 7)
                    SoundManager.StartBackground(SoundManager.BgSound.GameWon);
                else
                    SoundManager.StartBackground(SoundManager.BgSound.MainMenu);
                break;
            case "Entrance":
                SoundManager.StartBackground(SoundManager.BgSound.Background);
                break;
            case "GrandHall":
                SoundManager.StartBackground(SoundManager.BgSound.Background);

                //900 is 15 mins
                GameTime = 900;

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
    void OnPause()
    {
        IsGamePaused = !IsGamePaused;
    }
    void OnExit()
    {
        Application.Quit();
    }
    void OnDisable()
    {
        Debug.Log("GameManger Disable");
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
