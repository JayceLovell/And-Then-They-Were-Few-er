using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private Transform NewPos;

    public GameManager GameManager;
    public GameObject PlayerPrefab;
    public Transform DefaultSpawnLocation;
    public List<String> ExitLocationsName;
    public List<Transform> ExitLocationsPoint;
    

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
        GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        string lastScene = PlayerPrefs.GetString("LastScene", null);

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

        GameManager.SaveScene();

        //play door sound
        SoundManager.PlaySound(SoundManager.SoundFX.UseDoor);
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
        GameManager.SaveScene();
        SceneManager.LoadScene(SceneName);
    }
}
