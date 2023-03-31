using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClueButton : MonoBehaviour
{
    public Clue clue;

    public TextMeshProUGUI text;

    private void Start()
    {
        text.text = clue.ClueText;
    }

    public void OnClick()
    {
        if (GameManager.Instance.CurrentScene=="InterrogationScene")
        {
            GameObject.FindGameObjectWithTag("InterrogationController").GetComponent<InterrogationController>().PresentClueToNPC(clue);
        }
    }
}
