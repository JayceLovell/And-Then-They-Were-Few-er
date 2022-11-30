using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour
{
    public string SceneToLoad;
    public GameManager GameManager;
    public AudioClip TitleMusic;
    private AudioSource _titleMusicPlayer;
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
    void OnStart()
    {
        SceneManager.LoadScene(SceneToLoad);
    }
}
