using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControlPlayer : MonoBehaviour
{
    public float _playerSpeed;

    Transform trans;
    Rigidbody2D rb;
    public InputAction moveY;
    public InputAction moveX;
    public InputAction interact;
    Vector2 input = Vector2.zero;

    public bool CanInteract;
    bool _playerInteraction;

    public GameObject CurrentInteractableObject;

    void Awake()
    {

        rb = GetComponent<Rigidbody2D>();

        moveY.performed += _ctx => {

            input.y = _ctx.ReadValue<float>() * _playerSpeed;
        };

        moveY.canceled += _ctx => {

            input.y = 0f;
        };

        moveX.performed += _ctx => {

            input.x = _ctx.ReadValue<float>() * _playerSpeed;
        };

        moveX.canceled += _ctx => {

            input.x = 0f;
        };

        interact.started += _ctx => {
            _playerInteraction = true;
        };

        interact.canceled += _ctx =>
        {
            _playerInteraction = false;
        };

        
    }

    void OnEnable()
    {
        moveY.Enable();
        moveX.Enable();
        interact.Enable();

    }
    void OnDisable()
    {
        moveY.Disable();
        moveX.Disable();
        interact.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = input;

        if (CanInteract == true && _playerInteraction == true)
        {
            CurrentInteractableObject.GetComponent<Objects>().Use();
            FindObjectOfType<Interactable>().SetPlayerInteraction(true);
            _playerInteraction = false;

        }

    }
    void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.tag == "Interactable")
        {
            CurrentInteractableObject=collision.gameObject;
            CanInteract =true;
        }
    }

}
