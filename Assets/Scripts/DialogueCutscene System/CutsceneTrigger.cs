using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CutsceneTrigger : MonoBehaviour
{
    public PlayableAsset cutscene;

    public void EndCutscene()
    {
        DialogueManager.dialogueManager.EndCutscene();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        DialogueManager.dialogueManager.playableDirector.playableAsset = cutscene;
        DialogueManager.dialogueManager.playableDirector.Play();
        DialogueManager.dialogueManager.inCutscene = true;
        this.enabled = false;
    }
}
