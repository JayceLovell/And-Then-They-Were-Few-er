using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
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
    }
    // Awake is called before Start
    void Awake()
    {
        _instance = this;
        DontDestroyOnLoad(UiManager.Instance);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
