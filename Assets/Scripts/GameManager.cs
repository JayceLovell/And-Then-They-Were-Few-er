using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool _isGameOver;
    private static GameManager _instance;
    private AudioSource _musicPlayer;
    // This only public for testing
    [Range(0.0f, 100.0f)]
    private float _musicVolume;

    public float MusicVolume
    {
        get { 
            return (_musicVolume / 100);
        }
        set { 
            _musicVolume = value;
            _musicPlayer.volume = (_musicVolume / 100);
            PlayerPrefs.SetFloat("Volume", value);
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
        _musicPlayer.volume = MusicVolume;
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
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("Scene Loaded: " + scene.name);
        switch (scene.name)
        {
            case "Entrance":
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
