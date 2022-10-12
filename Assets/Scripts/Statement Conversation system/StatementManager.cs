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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckStatementCombination()
    {
        if(selectedStatement1 && selectedStatement2)
        {
            foreach (StatementCombinations combination in combinations)
            {
                if(combination.combinableStatements.Contains(selectedStatement1) && combination.combinableStatements.Contains(selectedStatement2))
                {
                    conclusions.Add(combination.conclusion);
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
