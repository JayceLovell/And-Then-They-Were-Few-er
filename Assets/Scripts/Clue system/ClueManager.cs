using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClueManager : MonoBehaviour
{
    public List<Clue> clues;

    public GameObject clueButton;

    public Transform clueListContent;

    public GameObject clueMenu;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < clues.Count; i++)
        {
            AddClueButton(clues[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (clueMenu.activeSelf)
            {
                clueMenu.SetActive(false);
            }
            else
            {
                clueMenu.SetActive(true);
            }
        }
    }

    public void AddClueButton(Clue clue)
    {
        ClueButton button = Instantiate(clueButton, clueListContent).GetComponent<ClueButton>();

        button.clueManager = this;
        button.clue = clue;
    }

    public void AddClue(Clue clue)
    {
        clues.Add(clue);

        AddClueButton(clue);
    }
}
