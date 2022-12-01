using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleController : MonoBehaviour
{
    public string SceneToLoad;
    public GameManager GameManager;
    public AudioClip TitleMusic;
    public GameObject VolumeSlider;

    private AudioSource _titleMusicPlayer;
    private bool _isVolumeDisplayed;
    public bool IsVolumeDisplayed
    {
        get { return _isVolumeDisplayed; }
        set { _isVolumeDisplayed = value; }
    }
    void Awake()
    {
        GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        _titleMusicPlayer = GetComponent<AudioSource>();

        _titleMusicPlayer.clip=TitleMusic;
        _titleMusicPlayer.Play();
    }

    // Update is called once per frame
    void Update()
    {
 
    }
    public void OnStart()
    {
        SceneManager.LoadScene(SceneToLoad);
    }
    public void DisplayVolume()
    {
        if (!_isVolumeDisplayed)
        {
            VolumeSlider.SetActive(true);
            _isVolumeDisplayed = true;
        }
        else
        {
            VolumeSlider.SetActive(false);
            _isVolumeDisplayed=false;
        }
    }
    public void VolumeLevel(float volume)
    {
        _titleMusicPlayer.volume = volume / 100;
    }
}
