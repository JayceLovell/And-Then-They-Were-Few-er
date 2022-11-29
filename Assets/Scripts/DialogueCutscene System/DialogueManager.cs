using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Playables;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager dialogueManager;

    public GameObject textbox;
    public TextMeshProUGUI text;

    public PlayableDirector playableDirector;

    public bool inDialogue;
    public bool inCutscene;

    public float textSpeed = 0.05f;

    [TextArea(15, 20)]
    public string[] currentDialogue;

    public int index;

    private void Awake()
    {
        dialogueManager = this;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (DialogueManager.dialogueManager.inDialogue)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (DialogueManager.dialogueManager.text.text == currentDialogue[index])
                {
                    NextLine();
                }
                else
                {
                    StopAllCoroutines();
                    DialogueManager.dialogueManager.text.text = currentDialogue[index];
                }
            }
        }
    }

    public void EndCutscene()
    {
        inCutscene = false;
    }

    public void OpenTextBox()
    {
        inDialogue = true;
        text.text = "";
        textbox.SetActive(true);
        StartCoroutine(TypeLine());
    }

    public void CloseTextBox()
    {
        textbox.SetActive(false);
        text.text = "";

        if (inCutscene)
        {
            playableDirector.Resume();
            inDialogue = false;
        }

        StartCoroutine(TurnOffDialogue());
    }

    IEnumerator TurnOffDialogue()
    {
        yield return new WaitForSeconds(0.3f);
        inDialogue = false;
    }

    IEnumerator TypeLine()
    {
        foreach (char c in currentDialogue[index].ToCharArray())
        {
            DialogueManager.dialogueManager.text.text += c;
            yield return new WaitForSeconds(DialogueManager.dialogueManager.textSpeed);
        }
    }

    void NextLine()
    {
        if (index < currentDialogue.Length - 1)
        {
            index++;
            DialogueManager.dialogueManager.text.text = "";
            StartCoroutine(TypeLine());
        }
        else
        {
            DialogueManager.dialogueManager.CloseTextBox();
        }
    }
}
