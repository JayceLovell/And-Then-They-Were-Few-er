using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clues : Objects
{
    public string ClueStatementText;
    public Clue ClueStatement;

    void Start()
    {
        //if (ClueStatement.PickedUp)
        //    Destroy(this.gameObject);

        if (GameManager.Instance.PlayerProgress == GameManager.GameState.BeforeMurder)
            if (objectType == TypeOfObject.Clue)
                this.gameObject.SetActive(false);
    }

    public override void Use()
    {
        base.Use();

        SoundManager.PlaySound(SoundManager.SoundFX.Clue);

        _dialogueObjectController.Display(true);
        _dialogueObjectController.InterrigationMode = false;
        StartCoroutine(Display());
        ClueStatement.ClueText = ClueStatementText;
        ClueStatement.PickedUp = true;
    }

    IEnumerator Display()
    {
        foreach (char c in Dialog.ToCharArray())
        {
            _dialogueObjectController.Text += c;
            yield return new WaitForSeconds(0.02f);
        }

        yield return new WaitForSeconds(0.5f);

        ClueManager.Instance.AddClue(ClueStatement);
        GameObject.Find("Player").GetComponent<Player>().Talking = false;
        Destroy(this.gameObject);
    }
}
