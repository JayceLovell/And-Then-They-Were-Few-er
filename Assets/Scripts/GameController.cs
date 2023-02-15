using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private Transform NewPos;
    private bool _inInterrogation;
    private Transform _lastPosition;

    public GameManager _gameManager;
    public GameObject PlayerPrefab;
    public Transform DefaultSpawnLocation;
    public List<String> ExitLocationsName;
    public List<Transform> ExitLocationsPoint;

    /// <summary>
    /// Is player leaving to go in Interrogation
    /// </summary>
    public bool InInterrogation
    {
        get
        {
            return _inInterrogation;
        }
        set
        {
            _inInterrogation = value;
        }
    }
    /// <summary>
    /// Hold the position of the player before going to interrogation room
    /// </summary>
    public Transform LastPositon
    {
        get { return _lastPosition; }
        set
        {
            _lastPosition = value;
        }
    }
    
    /// <summary>
    /// Update this with scens the gamecontroller is in
    /// </summary>
    public enum WhichScene
    {
        Test,
        LevelDesign,
        Game,
        Entrance,
        GrandHall,
        SecretRoom
    }

    public WhichScene Scene;

    void Awake()
    {
        _gameManager = GameManager.Instance;
    }
    // Start is called before the first frame update
    void Start()
    {
        if(InInterrogation)
        {
            Instantiate(PlayerPrefab,LastPositon.position,Quaternion.identity);
            InInterrogation=false;
        }
        else
        {
            string lastScene = _gameManager.LastScene;

            for(int i = 0; i < ExitLocationsName.Count; i++)
            {
                 if(lastScene == ExitLocationsName[i])
                {
                    NewPos = ExitLocationsPoint[i];
                    Instantiate(PlayerPrefab, NewPos.position,Quaternion.identity);
                    break;
                }
                if (i == ExitLocationsName.Count-1)
                    Instantiate(PlayerPrefab, DefaultSpawnLocation.position, Quaternion.identity);
            }
        //play door sound
        SoundManager.PlaySound(SoundManager.SoundFX.UseDoor);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /// <summary>
    /// Prepares and move to next scene
    /// </summary>
    /// <param name="SceneName"></param>
    public void MoveToScene(String SceneName)
    {
        _gameManager.LastScene = _gameManager.CurrentScene;
        SceneManager.LoadScene(SceneName);
    }
}
