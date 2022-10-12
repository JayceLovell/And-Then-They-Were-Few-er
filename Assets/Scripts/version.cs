using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class version : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       GetComponent<TextMeshProUGUI>().text = "Version: " + Application.version;
    }

}
