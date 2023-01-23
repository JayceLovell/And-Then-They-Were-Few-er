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


    public GameObject interogationArea;
    public GameObject MainCam;

    public bool inDialogue;
    public bool inCutscene;
    public bool inInterrogation;

    public float textSpeed = 0.05f;

    public Dialogue currentDialogueScript;

    [TextArea(15, 20)]
    public List<string> currentDialogue;

    public int index;

    public Clue currentCorrectClue;

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

        if (inInterrogation)
        {
            MainCam.SetActive(false);
            interogationArea.SetActive(true);
        }
        else
        {
            MainCam.SetActive(true);
            interogationArea.SetActive(false);
        }
    }
    public void ContinueDialog()
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

    public void EndCutscene()
    {
        inCutscene = false;
    }
    /// <summary>
    /// For Objects to put their text in Dialog
    /// </summary>
    /// <param name="Dialog"></param>
    public void ObjectDiablog(string Dialog)
    {
        text.text = "";
        textbox.SetActive(true);
        text.text = Dialog;
        StartCoroutine(TurnOffDialogue());
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

        index = 0;

        currentDialogue = null;

        if (inCutscene)
        {
            playableDirector.Resume();
            inDialogue = false;
        }

        if (inInterrogation)
        {
            inInterrogation = false;
            currentCorrectClue = null;
        }

        StartCoroutine(TurnOffDialogue());
    }

    void NextLine()
    {
        if (index < currentDialogue.Count - 1)
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
}
