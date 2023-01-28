using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class InterrogationController : MonoBehaviour
{
    private Sprite _interrogationNPC;
    private GameManager _gameManager;
    private string _playerName = "Ashlyn";
    private Component _npcComponent=null;

    public Sprite PlayerProfile;
    public DialogueObjectController DialogBox;
    public Transform NPCPosition;
    public GameObject NPC;
    

    public Sprite InterrogationNPC
    {
        get { return _interrogationNPC;}
        set { _interrogationNPC = value;}
    }
    // Start is called before the first frame update
    void Start()
    {
        _gameManager = GameManager.Instance;
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("InterrogationScene"));
        SceneManager.UnloadSceneAsync("GrandHall");

        StartCoroutine(WaitForOneSecond());

    }

        public void PlayerTalking()
    {
        DialogBox.SpeakerName = _playerName;
        DialogBox.SpeakerImage = PlayerProfile;
    }
    public void OnInteract()
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
        }
        if ((bool)_npcComponent.GetType().GetProperty("InDialog").GetValue(_npcComponent))
            _npcComponent.GetType().GetMethod("ContinueDialogue").Invoke(_npcComponent, null);
        else
        {
            DialogBox.Display();
            _npcComponent.GetType().GetMethod("StartDialogue").Invoke(_npcComponent, null);
        }
    }
    public void OnQuit()
    {
        GameManager.Instance.Quit();
    }
    IEnumerator WaitForOneSecond()
    {
        yield return new WaitForSeconds(1f);

        _gameManager.SaveScene();

        NPC = GameObject.FindGameObjectWithTag("NPC");
        NPC.transform.position = NPCPosition.position;
        OnInteract();
    }
}
