using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleController : MonoBehaviour
{
    private GameManager _gameManager;

    public Slider FXVolumeSlider;
    public Slider BGVolumeSlider;

    public float BGVolume
    {
        get { return _gameManager.BgmVolume; }
        set { _gameManager.BgmVolume = value; }
    }
    public float FXVolume
    {
        get { return _gameManager.SfxVolume; }
        set { _gameManager.SfxVolume = value; }
    }


    void Start()
    {
        _gameManager = GameManager.Instance;
        Button HelpButton = GameObject.Find("HelpButton").GetComponent<Button>();
        HelpButton.onClick.AddListener(delegate { _gameManager.LoadInstructions(); });

        FXVolumeSlider.value = _gameManager.SfxVolume;

        BGVolumeSlider.onValueChanged.AddListener(value => SoundManager.MasterVolumeChanged(value));
        BGVolumeSlider.value = _gameManager.BgmVolume;
    }
    void OnQuit()
    {
        _gameManager.Quit();
    }
    public void OnStart()
    {
        _gameManager.StartGame();
    }
    public void NewGame()
    {
        _gameManager.NewGame();
    }
}
