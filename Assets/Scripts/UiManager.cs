using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public GameObject Clock;
    public GameObject PauseMenuPrefab;
    public GameObject SaveIcon;

    private GameObject _pauseMenu;
    private TextMeshProUGUI _clockText;
    private int _timeHour;
    private int _timeMinute;
    private float _countDownMinutes;
    private float _countDownSeconds;
    private bool _isClockActive;
    private bool _isPauseActive;
    private GameManager _gameManager;
    private static UiManager _instance;
   
    public static UiManager Instance
    {
        get
        {
            if (_instance == null)
            {
                DontDestroyOnLoad(UiManager.Instance);
                Debug.LogError("Ui Manager is NULL");
            }
            return _instance;
        }
    }
    //CalledFirst
    void OnEnable()
    {
        Debug.Log("UiManager Enabled");
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    // Awake is called before Start
    void Awake()
    {
        _instance = this;
        DontDestroyOnLoad(UiManager.Instance);
    }
    void Start()
    {
        _gameManager = GameManager.Instance;
    }
    void Update()
    {
        if (_gameManager.IsGamePaused)
        {
            if (!_isPauseActive)
            {
                _pauseMenu = Instantiate(PauseMenuPrefab, GameObject.FindGameObjectWithTag("Canvas").transform);
                _isPauseActive = true;
                _setUpPauseMenuUI();
            }
        }
        else
        {
            if(_isPauseActive)
            {
                GameManager.Instance.SavePlayerPrefs();
                Destroy(_pauseMenu);
                _isPauseActive = false;
            }                

            if (_isClockActive)
                _updateClock();
        }
    }
    /// <summary>
    /// required stuff for pausemenu to work
    /// </summary>
    private void _setUpPauseMenuUI()
    {
        //Set Up Background Volume Slider
        Slider volumeslider = GameObject.Find("BGVolumeSlider").GetComponent<Slider>();
        volumeslider.value = _gameManager.BgmVolume;
        volumeslider.onValueChanged.AddListener(delegate { _gameManager.BgmVolume = volumeslider.value; });
        volumeslider.onValueChanged.AddListener(value => SoundManager.MasterVolumeChanged(value));

        //Set Up FX Volume Slider
        Slider FXvolumeslider = GameObject.Find("FXVolumeSlider").GetComponent<Slider>();
        FXvolumeslider.value = _gameManager.SfxVolume;
        FXvolumeslider.onValueChanged.AddListener(delegate { _gameManager.SfxVolume = FXvolumeslider.value; });

        //Set Up ResumeButton
        Button ResumeButton = GameObject.Find("ResumeButton").GetComponent<Button>();
        ResumeButton.onClick.AddListener(delegate { _gameManager.IsGamePaused = false; });

        //Set Up HelpButton
        Button HelpButton = GameObject.Find("HelpButton").GetComponent<Button>();
            HelpButton.onClick.AddListener(delegate { _gameManager.LoadInstructions(); });

        //Set Up SaveButton
        Button SaveButton = GameObject.Find("SaveButton").GetComponent<Button>();
        SaveButton.onClick.AddListener(delegate{ _gameManager.SavePlayerPrefs(); });

        //Set Up QuitButton
        Button QuitButton = GameObject.Find("QuitButton").GetComponent<Button>();
        QuitButton.onClick.AddListener(delegate { _gameManager.Quit(); });
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        switch (scene.name)
        {
            case "Entrance":
            case "GrandHall":
            case "InterrogationScene":
                StartCoroutine(FindRequiredGameObjects());
            break;
        }        
    }
    private void _updateClock()
    {
        switch (_gameManager.CurrentScene)
        {
            case "Entrance":
                if (_gameManager.PlayerProgress == GameManager.GameState.AfterMurder)
                {
                    _countDownMinutes = Mathf.FloorToInt(_gameManager.GameTime / 60);
                    _countDownSeconds = Mathf.FloorToInt(_gameManager.GameTime % 60);
                    _clockText.text = string.Format("{00:00}:{01:00}", _countDownMinutes, _countDownSeconds);
                }
                else
                    // Print time in 12 hr format
                    _clockText.text = DateTime.Now.ToString("hh:mm");

                break;
            case "GrandHall":
                _countDownMinutes = Mathf.FloorToInt(_gameManager.GameTime / 60);
                _countDownSeconds = Mathf.FloorToInt(_gameManager.GameTime% 60);
                _clockText.text= string.Format("{00:00}:{01:00}", _countDownMinutes,_countDownSeconds);
                break;
            default:
                if (GameManager.Instance.PlayerProgress == GameManager.GameState.BeforeMurder)
                {
                    _countDownMinutes = Mathf.FloorToInt(_gameManager.GameTime / 60);
                    _countDownSeconds = Mathf.FloorToInt(_gameManager.GameTime % 60);
                    _clockText.text = string.Format("{00:00}:{01:00}", _countDownMinutes, _countDownSeconds);
                }
                else
                    // Print time in 12 hr format
                    _clockText.text = DateTime.Now.ToString("hh:mm");
                break;
        }        
    }
    /// <summary>
    /// Shows Saving Icon
    /// </summary>
    public IEnumerator ShowSaving()
    {
        yield return new WaitForSeconds(1);
        GameObject Saving = Instantiate(SaveIcon, GameObject.FindGameObjectWithTag("Canvas").transform);
        yield return new WaitForSeconds(5);
        Destroy(Saving);
    }
    /// <summary>
    /// Reason for delay check is because the order of objects spawn in scene
    /// </summary>
    /// <returns></returns>
    IEnumerator FindRequiredGameObjects()
    {
        yield return new WaitForSeconds(1);

        // first do clock
        Clock = GameObject.FindGameObjectWithTag("Clock");
        _timeHour = System.DateTime.Now.Hour;
        _timeMinute = System.DateTime.Now.Minute;
        _clockText = Clock.GetComponentInChildren<TextMeshProUGUI>();
        _clockText.text = _timeHour.ToString() + ":" + _timeMinute.ToString();
        _isClockActive = true;

    }

    void OnDisable()
    {
        Debug.Log("UiManager Disable");
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

}
