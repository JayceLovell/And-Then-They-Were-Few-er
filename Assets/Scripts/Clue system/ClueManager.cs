using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClueManager : MonoBehaviour
{
    private static ClueManager _instance;

    public List<Clue> clues;

    public GameObject clueButton;

    public Transform clueListContent;

    public GameObject clueMenu;

    public static ClueManager Instance
    {
        get
        {
            if (_instance == null)
            {
                DontDestroyOnLoad(ClueManager.Instance);
                Debug.LogError("Clue Manager is NULL");
            }
            return _instance;
        }
    }
    //CalledFirst
    void OnEnable()
    {
        Debug.Log("Clue Manager Enabled");
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void Awake()
    {
        if (ClueManager.Instance == null)
            _instance = this;
        else
            Destroy(this.gameObject);
        DontDestroyOnLoad(ClueManager.Instance);
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < clues.Count; i++)
        {
            AddClueButton(clues[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (clueMenu.activeSelf)
            {
                clueMenu.SetActive(false);
            }
            else
            {
                clueMenu.SetActive(true);
            }
        }
    }

    public void AddClueButton(Clue clue)
    {
        ClueButton button = Instantiate(clueButton, clueListContent).GetComponent<ClueButton>();

        button.clueManager = this;
        button.clue = clue;
    }

    public void AddClue(Clue clue)
    {
        clues.Add(clue);

        AddClueButton(clue);
    }
    // Any stuff the manager has to do for each scene have it be done here
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        switch (scene.name)
        {
            case "Entrance":
            case "GrandHall":
            case "InterrogationScene":
               
                break;
        }
    }
    void OnDisable()
    {
        Debug.Log("Clue Manager Disable");
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
