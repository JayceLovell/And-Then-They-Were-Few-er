using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CloseInstructions : MonoBehaviour
{
   public void Close()
    {
        SceneManager.UnloadSceneAsync("Instructions");
    }
}
