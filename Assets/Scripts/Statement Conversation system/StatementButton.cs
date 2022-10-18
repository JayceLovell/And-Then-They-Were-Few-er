using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatementButton : MonoBehaviour
{
    public StatementManager statementManager;
    public Statement statement;

    public TextMeshProUGUI text;

    private void Start()
    {
        text.text = statement.statementText;
    }

    public void OnClick()
    {
        statementManager.SelectStatement(statement);
    }
}
