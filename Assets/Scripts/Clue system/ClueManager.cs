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
        get { return _clueMenu; }
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
    }
    /// <summary>
    /// Either display or remove Menu
    /// </summary>
    public void ToggleMenu()
    {
        if (_clueMenu.activeInHierarchy)      
            _clueMenu.SetActive(false);
        else
            _clueMenu.SetActive(true);
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
                StartCoroutine(WaitToGrabRequired());
                for (int i = 0; i < Clues.Count; i++)
                {
                    AddClueButton(Clues[i]);
                }
                break;
            default:
                break;
        }
    }
    IEnumerator WaitToGrabRequired()
    {
        yield return new WaitForSeconds(0.5f);

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
        
        if(_clueMenu==null)
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

        if (Clues.Count > 0)
        {
            foreach (Clue clue in Clues)
            {
                AddClueButton(clue);
            }
        }

    }
    void OnDisable()
    {
        Debug.Log("Clue Manager Disable");
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
