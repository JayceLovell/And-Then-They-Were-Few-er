using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class instructionsController : MonoBehaviour
{
    [SerializeField]
    private GameObject Instructions;
    [SerializeField]
    private GameObject Controlls;
    [SerializeField]
    private Button InstructionsButton;
    [SerializeField]
    private Button ControllsButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void SwitchToInstructions()
    {
        Instructions.SetActive(true);
        ControllsButton.interactable = true;

        InstructionsButton.interactable = false;
        Controlls.SetActive(false);
    }
    public void SwitchToControlls()
    {
        Instructions.SetActive(false);
        ControllsButton.interactable = false;

        InstructionsButton.interactable = true;
        Controlls.SetActive(true);
    }
    public void Close()
    {
        SceneManager.UnloadSceneAsync("Instructions");
    }
}
