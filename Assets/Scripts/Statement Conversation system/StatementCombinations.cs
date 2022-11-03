using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Statement Combination", menuName = "Statement Asset/Statement Combination")]
public class StatementCombinations : ScriptableObject
{
    public List<Statement> combinableStatements;

    public Conclusion conclusion;
}
