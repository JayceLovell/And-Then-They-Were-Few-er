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
    public GameObject VolumeSlider;

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
        
    }

    // Update is called once per frame
    void Update()
    {
 
    }
    public void OnStart()
    {
        SceneManager.LoadScene(SceneToLoad);
    }
    public void NewGame()
    {
        GameManager.NewGame();
        SceneManager.LoadScene(SceneToLoad);
    }
    public void DisplayVolume()
    {
        if (!_isVolumeDisplayed)
        {
            VolumeSlider.SetActive(true);
            _isVolumeDisplayed = true;
            VolumeSlider.GetComponent<Slider>().value = GameManager.BGMusicVolume;
        }
        else
        {
            VolumeSlider.SetActive(false);
            _isVolumeDisplayed=false;
        }
    }
}
