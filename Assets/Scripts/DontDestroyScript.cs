using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyScript : MonoBehaviour
{
    public bool removeParent;

    private void Awake()
    {
        if (removeParent)
        {
            gameObject.transform.parent = null;
        }

        DontDestroyOnLoad(gameObject);
    }
}
