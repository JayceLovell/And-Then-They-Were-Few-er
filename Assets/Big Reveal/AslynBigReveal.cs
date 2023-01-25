using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Playables;

public class AslynBigReveal : MonoBehaviour
{
    private int _numDialog;
    private bool _finishDialog;
    
    public bool FinishDialog
    {
        get
        {
            return _finishDialog;
        }
        set
        {
            _finishDialog = value;
            if (_finishDialog)
            {
                Director.Resume();
            }
        }
    }
    public GameObject DialogBox;
    public TextMeshProUGUI text;
    public PlayableDirector Director;
    [TextArea(15, 20)]
    public List<string> dialogueLines;

    // Start is called before the first frame update
    void Start()
    {
        _numDialog= 0;
        _finishDialog= false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Dialog()
    {
        text.text = "";
        DialogBox.SetActive(true);
        StartCoroutine(TypeLine());
        _numDialog++;
    }
    public void DirectorCheck()
    {
        if (!FinishDialog)
            Director.Pause();
    }
    IEnumerator TypeLine()
    {
        FinishDialog = false;
        foreach (char c in dialogueLines[_numDialog].ToCharArray())
        {
            text.text += c;
            yield return new WaitForSeconds(0.05f);
        }
        FinishDialog = true;
    }
}
