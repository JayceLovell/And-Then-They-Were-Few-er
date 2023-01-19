using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool _isGameOver;
    private static GameManager _instance;
    private AudioSource _musicPlayer;
    private int _currentPlayText;
    private float _bgMusicVolume;
    private float _sfxVolume;

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
            _musicPlayer.volume = (_bgMusicVolume / 100);
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
    public AudioClip GameOverMusic;
    public AudioClip BackgroundMusic;
    public AudioClip GameWonMusic;
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
        _musicPlayer = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {
        GameWinCondition = 5;
        IsGameOver = false;        
        CheckPlayerPrefs();
        _musicPlayer.volume = BGMusicVolume;
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
        
    }
    public void SaveScene()
    {
        CurrentScene = SceneManager.GetActiveScene().name;
        PlayerPrefs.SetString("LastScene", CurrentScene);
        PlayerPrefs.Save();
    }
    /// <summary>
    /// Don't forget to add scene stuff here for music
    /// </summary>
    /// <param name="scene"></param>
    /// <param name="mode"></param>
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("Scene Loaded: " + scene.name);
        switch (scene.name)
        {
            case "Entrance":
                _musicPlayer.volume = BGMusicVolume;
                _musicPlayer.clip = BackgroundMusic;
                _musicPlayer.Play();
                _musicPlayer.loop = true;
                break;
            case "GrandHall":
                _musicPlayer.volume=BGMusicVolume;
                _musicPlayer.clip = BackgroundMusic;
                _musicPlayer.Play();
                _musicPlayer.loop = true;
                break;
            default:
                if (_musicPlayer.isPlaying)
                {
                    _musicPlayer.Stop();
                }             
                break;
        }
    }
    void OnDisable()
    {
        Debug.Log("OnDisable");
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
