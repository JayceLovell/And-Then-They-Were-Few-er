using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Character parent class
/// </summary>
public class Character : MonoBehaviour
{
    private bool _playerInteracts;

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

    /// <summary>
    /// If player is interacting with object
    /// </summary>
    public bool PlayerInteracts
    {
        get { return _playerInteracts; }
        set { 
            _playerInteracts = value; 
            if(value)
                _playerInteracts = false;
        }
    }

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
    /// @DrCatman
    /// Put what this method does
    /// </summary>
    /// <param name="Interacts"></param>
    public void SetPlayerInteraction(bool Interacts)
    {
        _playerInteracts = Interacts;
    }
    /// <summary>
    /// returns a string of the characters name and trust level.
    /// </summary>
    /// <returns>string</returns>
    public string Trust()
    {
        return Name + "trust level is " + TrustLevel+".";
    }
    /// <summary>
    /// use this method by
    /// StartCoroutine(WaitInSeconds());
    /// </summary>
    /// <param name="seconds"></param>
    /// <returns>no resumes code</returns>
    IEnumerator WaitInSeconds(float seconds)
    {
        yield return new WaitForSeconds(seconds);
    }
}
