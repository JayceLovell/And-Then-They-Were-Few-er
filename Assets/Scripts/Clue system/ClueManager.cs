using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClueManager : MonoBehaviour
{
    private static ClueManager _instance;

    public List<Clue> Clues;

    public GameObject clueButton;

    [SerializeField]
    private ScrollRect clueListContent;

    [SerializeField]
    private GameObject _clueMenu;

    public GameObject ClueMenu
    {
        get {
            if(_clueMenu == null)
                FindClueMenu();
            return _clueMenu; 
        }
    }

    public static ClueManager Instance
    {
        get
        {            
            return _instance;
        }
    }
    //CalledFirst
    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void Awake()
    {
        // Check if there is already an instance of GameManager
        if (_instance != null && _instance != this)
        {
            // If there is an instance already, destroy this new one
            Destroy(this.gameObject);
            return;
        }

        // Set the instance of the GameManager
        _instance = this;

        DontDestroyOnLoad(ClueManager.Instance);
    }

    /// <summary>
    /// Either display or remove Menu
    /// </summary>
    public void ToggleMenu()
    {
        try
        {
            if (ClueMenu.activeInHierarchy)
                ClueMenu.SetActive(false);
            else
                ClueMenu.SetActive(true);
        }
        catch
        {
            Debug.LogError("Clue Menu is Null");
            StartCoroutine(WaitToGrabRequired());
        }
    }
    public void AddClueButton(Clue clue)
    {
        ClueButton button = Instantiate(clueButton, clueListContent.content).GetComponent<ClueButton>();

        button.clue = clue;
    }

    public void AddClue(Clue clue)
    {
        Clues.Add(clue);

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
                try
                {
                    StartCoroutine(WaitToGrabRequired());
                }
                catch
                {
                    Debug.Log("Something weird is going on");
                }
                break;
            default:
                break;
        }
    }
    IEnumerator WaitToGrabRequired()
    {
        yield return new WaitForSeconds(0.5f);

        FindClueMenu();

        if (ClueMenu == null)
            StartCoroutine(WaitToGrabRequired());
        else
        {
            for (int i = 0; i < _clueMenu.transform.childCount; i++)
            {
                Transform child = _clueMenu.transform.GetChild(i);

                if (child.name == "Clues")
                {
                    clueListContent = child.gameObject.GetComponent<ScrollRect>();
                    break;
                }
            }
        }

        //Add Clues buttons
        if (Clues.Count > 0)
        {
            foreach (Clue clue in Clues)
            {
                AddClueButton(clue);
            }
        }

    }
    /// <summary>
    /// Look for ClueMenu and assign it.
    /// </summary>
    private void FindClueMenu()
    {
        Transform canvasTransform = GameObject.Find("Canvas").transform;

        for (int i = 0; i < canvasTransform.childCount; i++)
        {
            Transform child = canvasTransform.GetChild(i);

            if (child.name == "Clue Menu Prefab")
            {
                _clueMenu = child.gameObject;
                break;
            }
        }
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
