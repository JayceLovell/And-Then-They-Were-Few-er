using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public GameObject Clock;

    private TextMeshProUGUI _clockText;
    private int _timeHour;
    private int _timeMinute;
    private float _countDownMinutes;
    private float _countDownSeconds;
    private bool _isClockActive;
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
        _gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }
    void Update()
    {
        if (_isClockActive)
            _updateClock();
    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        switch (scene.name)
        {
            case "Entrance":
            case "GrandHall":
                StartCoroutine(FindClock());
            break;
        }        
    }
    private void _updateClock()
    {
        switch (_gameManager.CurrentScene)
        {
            case "Entrance":
                if (_gameManager.CurrentGameProgress > 2)
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
                _clockText.text = "00:00";
                break;
        }        
    }
    private void _removeClock()
    {
        Clock.SetActive(false);
    }
    IEnumerator FindClock()
    {
        yield return new WaitForSeconds(2);

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
