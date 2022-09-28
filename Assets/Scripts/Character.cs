using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    /// <summary>
    /// Characters trust level with player
    /// </summary>
    [Range(0, 10)]
    public int TrustLevel;


    public string Name;

    public bool isAlive;



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
    public string Trust()
    {
        return Name + "trust level is " + TrustLevel+".";
    }
}
