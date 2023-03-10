using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleController : MonoBehaviour
{
    private GameManager _gameManager;

    public Slider FXVolumeSlider;
    public Slider BGVolumeSlider;
    public TMP_Dropdown resolutionDropdown;

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

        //populate resolutionDropdown
        resolutionDropdown.ClearOptions();
        Resolution[] resolutions = Screen.resolutions;
        int currentResolutionIndex = GetCurrentResolution(resolutions);
        foreach (Resolution resolution in resolutions)
        {
            string optionFullscreen = resolution.width + " x " + resolution.height + " (fullscreen)";
            string optionWindowed = resolution.width + " x " + resolution.height + " (windowed)";
            string optionText = optionFullscreen;
            if (resolution.refreshRate > 0)
            {
                optionText += " " + resolution.refreshRate + "Hz";
            }
            resolutionDropdown.options.Add(new TMP_Dropdown.OptionData(optionText));
        }
        resolutionDropdown.RefreshShownValue();
        resolutionDropdown.value = currentResolutionIndex;

        // add display index to dropdown if multiple displays
        if (Display.displays.Length > 1)
        {
            resolutionDropdown.options.Insert(0, new TMP_Dropdown.OptionData("Display 1"));
            for (int i = 1; i < Display.displays.Length; i++)
            {
                resolutionDropdown.options.Add(new TMP_Dropdown.OptionData("Display " + (i + 1)));
            }
        }
    }

    /// <summary>
    /// Get what the current screen resolution is
    /// </summary>
    /// <param name="resolutions">List of Resolutions</param>
    /// <returns></returns>
    private int GetCurrentResolution(Resolution[] resolutions)
    {
        int currentWidth = Screen.currentResolution.width;
        int currentHeight = Screen.currentResolution.height;
        int currentRefreshRate = Screen.currentResolution.refreshRate;
        for (int i = 0; i < resolutions.Length; i++)
        {
            if (resolutions[i].width == currentWidth && resolutions[i].height == currentHeight && resolutions[i].refreshRate == currentRefreshRate)
            {
                return i;
            }
        }
        return 0;
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
    /// <summary>
    /// When resolution is selected
    /// </summary>
    /// <param name="index"></param>
    public void OnResolutionPicked(int index)
    {
        Resolution[] resolutions = Screen.resolutions;
        int resolutionIndex = index / 2;
        bool isFullscreen = index % 2 == 0;
        Resolution resolution = resolutions[resolutionIndex];
        int monitorIndex = GetCurrentMonitor(resolution);
        Screen.SetResolution(resolution.width, resolution.height, isFullscreen, monitorIndex);
    }
    /// <summary>
    /// Get the index of the monitor that the resolution is currently on
    /// </summary>
    /// <param name="resolution"></param>
    /// <returns></returns>
    private int GetCurrentMonitor(Resolution resolution)
    {
        int currentMonitor = 0;
        for (int i = 0; i < Display.displays.Length; i++)
        {
            if (Display.displays[i].active && Display.displays[i].systemWidth == resolution.width && Display.displays[i].systemHeight == resolution.height)
            {
                currentMonitor = i;
                break;
            }
        }
        return currentMonitor;
    }
}
