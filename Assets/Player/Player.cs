using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public float PlayerSpeed;
    public bool CanInteract;

    public GameObject CurrentInteractableObject;

    public GameObject PlayerObjectTextBox;

    private Rigidbody2D rigidbody;
    private Animator animator;
    private AudioSource audioSource;

    public Vector2 moveInput = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().SfxVolume;
    }
    void FixedUpdate()
    {
        if(DialogueManager.dialogueManager.inCutscene || DialogueManager.dialogueManager.inDialogue)
        {
            moveInput = Vector2.zero;
        }

        rigidbody.velocity = moveInput * PlayerSpeed;
        switch (moveInput.y)
        {
            case 1:
                animator.SetBool("Up", true);
                break;
            case -1:
                animator.SetBool("Down", true);
                break;
            default:
                animator.SetBool("Up", false);
                animator.SetBool("Down", false);
                break;
        }
        switch (moveInput.x)
        {
            case 1:
                animator.SetBool("Right", true);
                break;
            case -1:
                animator.SetBool("Left", true);
                break;
            default:
                animator.SetBool("Left", false);
                animator.SetBool("Right", false);
                break;
        }
    }
    /// <summary>
    /// Responds to input system on move event
    /// </summary>
    /// <param name="value">The value which containts the vector2 X/Y input</param>
    void OnMove(InputValue value)
    {
        moveInput=value.Get<Vector2>();
    }
    void OnInteract()
    {
        if (CanInteract)
        {
            CurrentInteractableObject.GetComponent<Objects>().Use();
        }
    }
    void OnExit()
    {
        Application.Quit();
    }
    void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.tag == "Interactable")
        {
            CurrentInteractableObject = collision.gameObject;
            CanInteract = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        CurrentInteractableObject = null;
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Interactable")
        {
            CurrentInteractableObject = collision.gameObject;
            CanInteract = true;
            PlayerObjectTextBox.SetActive(true);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        CurrentInteractableObject = null;
        PlayerObjectTextBox.SetActive(false);
    }
}
