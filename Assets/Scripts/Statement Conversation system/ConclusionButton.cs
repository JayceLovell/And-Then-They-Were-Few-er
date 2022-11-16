using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ConclusionButton : MonoBehaviour
{
    public StatementManager statementManager;
    public Conclusion conclusion;

    public TextMeshProUGUI text;

    private void Start()
    {
        text.text = conclusion.conclusionText;
    }

    public void OnClick()
    {

    }
}
