using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    /// <summary>
    /// Characters trust level with player
    /// </summary>
    [Range(0, 10)]
    [Tooltip("Characters Trust level")]
    public int TrustLevel;

    
    [Tooltip("Name of Character")]
    public string Name;

    [Tooltip("Dead or alive o.o")]
    public bool isAlive;

    /// <summary>
    /// Where the character should be based on story progression and trust level
    /// </summary>
    [Tooltip("Positions for characters to be in")]
    public List<Vector3> Positions;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DefaultConvo()
    {

    }
    /// <summary>
    /// returns a string of the characters name and trust level.
    /// </summary>
    /// <returns>string</returns>
    public string Trust()
    {
        return Name + "trust level is " + TrustLevel+".";
    }
}
