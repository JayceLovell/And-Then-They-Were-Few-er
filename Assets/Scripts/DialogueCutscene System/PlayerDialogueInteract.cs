using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDialogueInteract : MonoBehaviour
{
    Collider2D currentNPC;

    public Sprite NPCSprite;
    public GameObject NPCDisplay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentNPC && Input.GetKeyDown(KeyCode.E) && DialogueManager.dialogueManager.inDialogue == false)
        {
            currentNPC.transform.GetComponentInParent<Dialogue>().StartDialogueSequence();           
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "NPC" && DialogueManager.dialogueManager.inDialogue == false)
        {
            currentNPC = collision;

            // Wrote this since character isn't animating just static
            NPCSprite = collision.transform.GetComponentInParent<SpriteRenderer>().sprite;
            //In future use this to grab the interrigation sprite.
            //collision.transform.GetComponentInParent<Character>().InterrigationSprite;
            NPCDisplay.GetComponent<SpriteRenderer>().sprite = NPCSprite;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (currentNPC == collision)
        {
            currentNPC = null;
        }
    }
}
