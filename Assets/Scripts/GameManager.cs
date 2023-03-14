using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
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
    private float _bgmVolume;
    private float _sfxVolume;
    private string _currentScene;
    private string _lastScene;

    public Character.CharacterName Chosen;

    /// <summary>
    /// Players State in game
    /// </summary>
    public enum GameState
    {
        NewGame,
        BeforeMurder,
        AfterMurder,
        GameWon,
        TimeOut,
        WrongPerson
    }

    public GameState PlayerProgress;

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
            if (_gameTime <= 0)
            {
                PlayerProgress = GameState.TimeOut;
                IsGameOver = true;
            }                
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
    /// Background music volume
    /// </summary>
    public float BgmVolume
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
    public float SfxVolume {
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
                PlayerProgress = GameState.WrongPerson;
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
                PlayerProgress = GameState.GameWon;
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
            _currentScene = SceneManager.GetActiveScene().name;
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
        // Check if there is already an instance of GameManager
        if (_instance != null && _instance != this)
        {
            // If there is an instance already, destroy this new one
            Destroy(this.gameObject);
            return;
        }

        // Set the instance of the GameManager
        _instance = this;

        DontDestroyOnLoad(GameManager.Instance);
    }
    // Start is called before the first frame update
    void Start()
    {
        IsGameOver = false;
        IsGamePaused = false;        
    }

    // Update is called once per frame
    void Update()
    {
        if (!IsGamePaused||!IsGameOver||!IsGameWon||_gameTime>0)
        {
            if (_timeStart||PlayerProgress==GameState.AfterMurder)
            {
                 GameTime -= Time.deltaTime;
            }
        }
    }
    private void _loadPlayerPrefs()
    {
        if(!PlayerPrefs.HasKey("SFX Volume"))        
            SfxVolume = 50;
        else
            SfxVolume = PlayerPrefs.GetFloat("SFX Volume");

        if (!PlayerPrefs.HasKey("BGM Volume"))
            BgmVolume = 50;
        else
            BgmVolume = PlayerPrefs.GetFloat("BGM Volume");

        if (PlayerPrefs.GetFloat("Game Time") <= 0)
            _gameTime = 900;
        else
            _gameTime = PlayerPrefs.GetFloat("Game Time");

        _lastScene = PlayerPrefs.GetString("Last Scene","");
        _currentScene = PlayerPrefs.GetString("Current Scene","");
        PlayerProgress = (GameState)Enum.ToObject(typeof(GameState),PlayerPrefs.GetInt("Player Progress"));

        string cluesNameString = PlayerPrefs.GetString("Clues Name", "");
        string cluesString = PlayerPrefs.GetString("Clues", "");
        string pickedUpString = PlayerPrefs.GetString("Clues Picked Up", "");

        string[] cluesName = cluesNameString.Split(',');
        string[] cluesArray = cluesString.Split(',');
        string[] pickedUpArray = pickedUpString.Split(',');
        List<Clue> clues = new List<Clue>();
        for (int i = 0; i < cluesArray.Length; i++)
        {
            if (cluesArray[i] != "")
            {
                //Clue clue = new Clue();
                Clue clue = ScriptableObject.CreateInstance<Clue>();
                clue.name = cluesName[i];
                clue.ClueText = cluesArray[i];
                clue.PickedUp = (pickedUpArray[i] == "1");
                clues.Add(clue);
            }
        }
        ClueManager.Instance.Clues = clues;

        PlayerPrefs.SetString("Playing", "Playing");
    }
    public async void SavePlayerPrefs()
    {
        await Task.Delay(5000);

        int gameStateInt = Convert.ToInt32(PlayerProgress);
        PlayerPrefs.SetInt("Player Progress", gameStateInt);
        PlayerPrefs.SetFloat("BGM Volume", _bgmVolume);
        PlayerPrefs.SetFloat("SFX Volume", _sfxVolume);
        PlayerPrefs.SetFloat("Game Time", _gameTime);
        PlayerPrefs.SetString("Current Scene", _currentScene);
        PlayerPrefs.SetString("Last Scene",_lastScene);

        string ClueName = "";
        string CluesString = "";
        string PickedUpString = "";

        foreach (Clue clue in ClueManager.Instance.Clues)
        {
            ClueName += clue.name + ",";
            CluesString += clue.ClueText + ",";
            PickedUpString += clue.PickedUp ? "1," : "0,";
        }

        PlayerPrefs.SetString("Clues Name", ClueName);
        PlayerPrefs.SetString("Clues", CluesString);
        PlayerPrefs.SetString("Clues Picked Up", PickedUpString);

        switch (CurrentScene)
        {
            case "Entrance":
            case "GrandHall":
                StartCoroutine(UiManager.Instance.ShowSaving());
                break;
            default: 
                break;
        }
        
        PlayerPrefs.Save();
    }
    /// <summary>
    /// Prepares new Game
    /// </summary>
    public void NewGame()
    {
        PlayerPrefs.DeleteAll();
        SavePlayerPrefs();
        _loadPlayerPrefs();
        PlayerProgress = GameState.NewGame;
        IsGameOver = false;
        IsGameWon = false;
        IsGamePaused = false;
        
        GameTime = 900;
        StartGame();
    }
    public void StartGame()
    {
        //check if player is new
        if(PlayerPrefs.HasKey("Playing"))
        {
            _loadPlayerPrefs();
            //_lastScene = _currentScene;
            if (PlayerProgress == GameState.NewGame)
                SceneManager.LoadScene("Text");
            else if (PlayerProgress == GameState.AfterMurder)
                SceneManager.LoadScene("GrandHall");
            else if (PlayerProgress == GameState.BeforeMurder)
                SceneManager.LoadScene("Entrance");

            PlayerPrefs.SetString("Playing", "Playing");
        }
        else
            // Run game as new player
            NewGame();        
    }
    public void GameOver(Character.CharacterName Chosen)
    {
        this.Chosen = Chosen;
        IsGameOver = true;
    }
    /// <summary>
    /// Calls on scene/summary>
    /// <param name="scene"></param>
    /// <param name="mode"></param>
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        switch (scene.name)
        {
            case "Title":
                SoundManager.StartBackground(SoundManager.BgSound.Title);               
                break;
            case "Text":
                if (PlayerProgress == GameState.TimeOut || PlayerProgress == GameState.WrongPerson)
                    SoundManager.StartBackground(SoundManager.BgSound.GameLost);
                else if (PlayerProgress == GameState.GameWon)
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
        SavePlayerPrefs();
    }
    void OnSceneUnloaded(Scene current)
    {
        _lastScene = SceneManager.GetActiveScene().name;        
    }
    public void LoadInstructions()
    {
        SceneManager.LoadScene("Instructions", LoadSceneMode.Additive);
    }
    public void Quit()
    {        
        SavePlayerPrefs();
        Application.Quit();
    }
    void OnDisable()
    {
        Debug.Log("GameManger Disable");
        //SceneManager.sceneLoaded -= OnSceneLoaded;
        //SceneManager.sceneUnloaded -= OnSceneUnloaded;
    }
}
