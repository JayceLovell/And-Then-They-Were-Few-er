using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Playables;

/// <summary>
/// This script is only just Ashlyn Big Reveal Scene
/// Do not use in any other scene
/// :D thanks
/// </summary>
public class AshlynBigReveal : Character
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
            if (_finishDialog && (_numDialog<DialogueLines.Count))
            {
                Director.playableGraph.GetRootPlayable(0).Play();
            }
        }
    }
    public DialogueObjectController DialogBox;
    public PlayableDirector Director;
    public GameObject SelectionPanel;
    [TextArea(15, 20)]
    public List<string> DialogueLines;

    // Start is called before the first frame update
    void Start()
    {
        _numDialog= 0;
        _finishDialog= false;
    }
    /// <summary>
    /// Talk
    /// </summary>
    public void Dialog()
    {
        DialogBox.InterrigationMode = false;
        DialogBox.Text = "";
        DialogBox.SpeakerName = Name.ToString();
        DialogBox.SpeakerImage = Profile;
        StartCoroutine(TypeLine());
        _numDialog++;
    }
    /// <summary>
    /// Check if finish talking
    /// </summary>
    public void DirectorCheck()
    {
        if (!FinishDialog)
            Director.playableGraph.GetRootPlayable(0).Pause();
    }
    /// <summary>
    /// Player makes decision
    /// </summary>
    public void TimeToMakeDecision()
    {
        DialogBox.Display(false);
        SelectionPanel.SetActive(true);

    }
    /// <summary>
    /// hold up one at a time
    /// </summary>
    /// <returns></returns>
    IEnumerator TypeLine()
    {
        FinishDialog = false;
        foreach (char c in DialogueLines[_numDialog].ToCharArray())
        {
            DialogBox.Text += c;
            yield return new WaitForSeconds(0.02f);
        }
        FinishDialog = true;

        if (_numDialog >= DialogueLines.Count)
            TimeToMakeDecision();

    }
}
