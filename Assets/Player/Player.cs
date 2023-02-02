using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Profiling;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private Animator _animator;
    private bool _talking;

    private GameController _gameController;

    public float PlayerSpeed;
    public bool CanInteract;
    public bool CanTalkToNPC;

    public Sprite Profile;
    public Sprite InterrigationSprite;

    public Sprite NPCSprite;
    public GameObject NPCDisplay;
    public GameObject CurrentInteractableObject;
    public GameObject CurrentNPCToTalkTo;
    public GameObject PlayerObjectTextBox;
    public Vector2 moveInput = Vector2.zero;
    public DialogueObjectController DialogBox;

    public bool Talking
    {
        get
        {
            return _talking;
        }
        set
        {
            _talking = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }
    void FixedUpdate()
    {
        if(Talking)
        {
            moveInput = Vector2.zero;
        }

        _rigidbody.velocity = moveInput * PlayerSpeed;
        switch (moveInput.y)
        {
            case 1:
                _animator.SetBool("Up", true);
                break;
            case -1:
                _animator.SetBool("Down", true);
                break;
            default:
                _animator.SetBool("Up", false);
                _animator.SetBool("Down", false);
                break;
        }
        switch (moveInput.x)
        {
            case 1:
                _animator.SetBool("Right", true);
                break;
            case -1:
                _animator.SetBool("Left", true);
                break;
            default:
                _animator.SetBool("Left", false);
                _animator.SetBool("Right", false);
                break;
        }
    }
    /// <summary>
    /// Responds to input system on move event
    /// </summary>
    /// <param name="value">The value which containts the vector2 X/Y input</param>
    void OnMove(InputValue value)
    {
        if (!_gameController.GameManager.IsGamePaused)
        {
            if (value.Get<Vector2>().x != 0 && value.Get<Vector2>().y == 0)
                moveInput = value.Get<Vector2>();
            else if (value.Get<Vector2>().y != 0 && value.Get<Vector2>().x == 0)
                moveInput = value.Get<Vector2>();
            else
                moveInput = Vector2.zero;

            SoundManager.PlaySound(SoundManager.SoundFX.PlayerWalk);
        }
    }
    /// <summary>
    /// Interact with Interactble Object Or NPC
    /// Normall E button
    /// </summary>
    void OnInteract()
    {
        if (CanTalkToNPC)
        {
            Component CharactersScript = null;
            // LOOK JAYCE IF YOU LOOKING BACK AT THIS. THIS IS YOUR HIGHEST MOMENT IN CODING FOR EARLY 2023
            Component[] components = CurrentNPCToTalkTo.GetComponents(typeof(Component));
            foreach (Component component in components)
            {
                if(component.GetType().Name == CurrentNPCToTalkTo.name)
                {
                    CharactersScript= component;
                    break;
                }
            }
            // If already talking next set of dialogue
            if ((bool) CharactersScript.GetType().GetProperty("InDialog").GetValue(CharactersScript))
                CharactersScript.GetType().GetMethod("ContinueDialogue").Invoke(CharactersScript, null);
            else
            {
                if (_gameController.GameManager.CurrentScene == "GrandHall")
                {
                    _gameController.InInterrogation= true;
                    _gameController.LastPositon = this.gameObject.transform;

                    SceneManager.LoadScene("InterrogationScene",LoadSceneMode.Additive);
                    SceneManager.MoveGameObjectToScene(CurrentNPCToTalkTo, SceneManager.GetSceneByName("InterrogationScene"));                    
                }
                else
                {
                    Talking = true;
                    DialogBox.Display(true);
                    CharactersScript.GetType().GetMethod("StartDialogue").Invoke(CharactersScript, null);
                }
            }
        }
        // Interacting with object
        else if (CanInteract)
        {
            CurrentInteractableObject.GetComponent<Objects>().Use();
        }
        else
        {
            //for future use
        }

    }
    public void ImTalking()
    {
        DialogBox.SpeakerName = "Ashlyn";
        DialogBox.SpeakerImage = Profile;                
    }
    void OnPause()
    {
        GameManager.Instance.IsGamePaused = !GameManager.Instance.IsGamePaused;
    }
    void OnQuit()
    {
        GameManager.Instance.Quit();
    }
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.gameObject.tag == "NPC")
    //    {
    //        CurrentNPCToTalkTo = collision.gameObject;
    //        CanTalkToNPC = true;
    //        // Wrote this since character isn't animating just static
    //        NPCSprite = collision.transform.GetComponentInParent<SpriteRenderer>().sprite;
    //        //In future use this to grab the interrigation sprite.
    //        //collision.transform.GetComponentInParent<Character>().InterrigationSprite;
    //        NPCDisplay.GetComponent<SpriteRenderer>().sprite = NPCSprite;
    //    }
    //}
    void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.tag == "Interactable")
        {
            CurrentInteractableObject = collision.gameObject;
            CanInteract = true;
            PlayerObjectTextBox.SetActive(true);
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "NPC")
        {
            CurrentNPCToTalkTo = collision.gameObject;
            CanTalkToNPC = true;
            // Wrote this since character isn't animating just static
            NPCSprite = collision.transform.GetComponentInParent<SpriteRenderer>().sprite;
            //In future use this to grab the interrigation sprite.
            //collision.transform.GetComponentInParent<Character>().InterrigationSprite;
           // NPCDisplay.GetComponent<SpriteRenderer>().sprite = NPCSprite;
        }
        if (collision.gameObject.tag == "Interactable")
        {
            CurrentInteractableObject = collision.gameObject;
            CanInteract = true;
            PlayerObjectTextBox.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        NPCSprite = null;
        CurrentInteractableObject = null;
        CurrentNPCToTalkTo = null;
        CanInteract = false;
        CanTalkToNPC = false;
        PlayerObjectTextBox.SetActive(false);
        DialogueManager.dialogueManager.CloseTextBox();
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        NPCSprite = null;
        CurrentInteractableObject = null;
        CurrentNPCToTalkTo = null;
        CanInteract = false;
        CanTalkToNPC = false;
        PlayerObjectTextBox.SetActive(false);
        DialogueManager.dialogueManager.CloseTextBox();
    }
}
