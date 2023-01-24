using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigRevealController : MonoBehaviour
{
    public GameObject SelectionPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Selected(string Selection)
    {
        switch (Selection)
        {
            case "Damian":
                break;
            default:
                Debug.Log("Havn't written code for that yet");
                break;
        }
    }
}
