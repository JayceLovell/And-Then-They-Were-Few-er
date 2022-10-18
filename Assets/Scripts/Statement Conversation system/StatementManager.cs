using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatementManager : MonoBehaviour
{
    public List<Statement> statements;
    public List<StatementCombinations> combinations;
    public List<Conclusion> conclusions;

    public Statement selectedStatement1;
    public Statement selectedStatement2;

    public GameObject statementButton;
    public GameObject conclusionButton;

    public Transform statementListContent;
    public Transform conclusionListContent;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < statements.Count; i++)
        {
            AddStatementButton(statements[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddStatementButton(Statement statement)
    {
        StatementButton button = Instantiate(statementButton, statementListContent).GetComponent<StatementButton>();

        button.statementManager = this;
        button.statement = statement;
    }

    public void AddStatement(Statement statement)
    {
        statements.Add(statement);

        AddStatementButton(statement);
    }

    public void AddConclusion(Conclusion conclusion)
    {
        conclusions.Add(conclusion);

        ConclusionButton button = Instantiate(conclusionButton, conclusionListContent).GetComponent<ConclusionButton>();

        button.statementManager = this;
        button.conclusion = conclusion;
    }

    public void CheckStatementCombination()
    {
        if(selectedStatement1 && selectedStatement2)
        {
            foreach (StatementCombinations combination in combinations)
            {
                if(combination.combinableStatements.Contains(selectedStatement1) && combination.combinableStatements.Contains(selectedStatement2))
                {
                    AddConclusion(combination.conclusion);
                }
            }

            selectedStatement1 = null;
            selectedStatement2 = null;
        }
    }

    public void SelectStatement(Statement newStatement)
    {
        if(selectedStatement1 == null)
        {
            selectedStatement1 = newStatement;
        }
        else if(selectedStatement2 == null)
        {
            selectedStatement2 = newStatement;

            CheckStatementCombination();
        }
    }
}
