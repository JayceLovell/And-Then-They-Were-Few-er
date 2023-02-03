using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleController : MonoBehaviour
{
    private GameManager _gameManager;
    public GameObject VolumeSlider;

    private bool _isVolumeDisplayed;
    public bool IsVolumeDisplayed
    {
        get { return _isVolumeDisplayed; }
        set { _isVolumeDisplayed = value; }
    }
    void Start()
    {
        _gameManager = GameManager.Instance;
    }
    public void OnStart()
    {
        _gameManager.StartGame();
    }
    public void NewGame()
    {
        _gameManager.NewGame();
    }
    public void DisplayVolume()
    {
        if (!_isVolumeDisplayed)
        {
            VolumeSlider.SetActive(true);
            _isVolumeDisplayed = true;
            VolumeSlider.GetComponent<Slider>().value = _gameManager.BGMVolume;
        }
        else
        {
            VolumeSlider.SetActive(false);
            _isVolumeDisplayed=false;
        }
    }
}
