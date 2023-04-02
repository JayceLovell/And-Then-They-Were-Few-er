using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
using UnityEditor;

public class InterrogationController : MonoBehaviour
{
    private Sprite _interrogationNPC;
    private Component _npcComponent=null;
    private int _nextElementForInterrogating;
    [SerializeField]
    private Sprite Profile;

    public Material ShadowMaterial;
    public Sprite PlayerProfile;
    public DialogueObjectController DialogBox;
    public Transform NPCPosition;
    public GameObject NPC;

    public GameObject EventSystemObject;
    public GameObject CameraObject;

    public int NextElementForInterrogating
    {
        get
        {
            return _nextElementForInterrogating;
        }
        set
        {          
            _nextElementForInterrogating = value;
            if((bool)_npcComponent.GetType().GetProperty("CluePresented").GetValue(_npcComponent))
                _npcComponent.GetType().GetProperty("NumDialogAfterClue").SetValue(_npcComponent, value);
            else
                _npcComponent.GetType().GetProperty("NumDialog").SetValue(_npcComponent, value);

            _npcComponent.GetType().GetMethod("ContinueDialogue").Invoke(_npcComponent, null);
        }
    }
    

    public Sprite InterrogationNPC
    {
        get { return _interrogationNPC;}
        set { _interrogationNPC = value;}
    }
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("InterrogationScene"));
        //Grab profile quick before disappear
        Profile = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().Profile;

        SceneManager.UnloadSceneAsync("GrandHall");

        StartCoroutine(WaitForOneSecond());

    }    
    public void OnInterrogate()
    {

        if (_npcComponent == null)
        {
            Component[] components = NPC.GetComponents(typeof(Component));
            foreach (Component component in components)
            {
                if (component.GetType().Name == NPC.name)
                {
                    _npcComponent = component;
                    break;
                }
            }

            //sets up the shadows of npcs
            _npcComponent.GetComponent<Renderer>().shadowCastingMode= UnityEngine.Rendering.ShadowCastingMode.On;
            _npcComponent.GetComponent<Renderer>().receiveShadows = true;
            _npcComponent.GetComponent<Renderer>().material = ShadowMaterial;
            

        }
        if ((bool)_npcComponent.GetType().GetProperty("InDialog").GetValue(_npcComponent))
            _npcComponent.GetType().GetMethod("ContinueDialogue").Invoke(_npcComponent, null);
        else
        {
            DialogBox.Display(true);
            _npcComponent.GetType().GetMethod("StartDialogue").Invoke(_npcComponent, null);
        }
    }
    public void PlayerTalking()
    {
        DialogBox.SpeakerName = "Ashlyn";
        DialogBox.SpeakerImage = Profile;
    }
    public void PresentClueToNPC(Clue clue)
    {
        _npcComponent.GetType().GetMethod("PresentClue").Invoke(_npcComponent, new object[] { clue });
    }
    void OnBringUpClues()
    {
        ClueManager.Instance.ToggleMenu();
    }
    public void OnQuit()
    {
        SceneManager.LoadScene("GrandHall");
    }
    public void Back()
    {
        SceneManager.LoadScene("GrandHall");
    }
    IEnumerator WaitForOneSecond()
    {
        yield return new WaitForSeconds(0.5f);

        NPC = GameObject.FindGameObjectWithTag("NPC");
        NPC.transform.position = NPCPosition.position;

        //idk why but gotta do this

        CameraObject.SetActive(true);
        EventSystemObject.SetActive(true);
        gameObject.GetComponent<PlayerInput>().enabled= false;
        gameObject.GetComponent<PlayerInput>().enabled = true;


        OnInterrogate();
    }
}
