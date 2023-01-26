using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigRevealController : MonoBehaviour
{

    public void Selected(Character.CharacterName characterName)
    {
        switch (characterName)
        {
            case Character.CharacterName.Ashlyn:
            case Character.CharacterName.Damien:
            case Character.CharacterName.Frederick:
            case Character.CharacterName.Jayson:
            case Character.CharacterName.John:
            case Character.CharacterName.Karol:
            case Character.CharacterName.Mirianne:            
            case Character.CharacterName.Nikki:
            case Character.CharacterName.OldCrazyMan:
                GameManager.Instance.IsGameOver = true;
                break;
            case Character.CharacterName.Rachel:
                GameManager.Instance.IsGameWon = true;
                break;
            default:
                Debug.Log("Havn't written code for that yet");
                break;
        }
    }
    
    // even im ashamed of what i put below here
    // don't look Q_Q
    public void SelectedAshlyn() => Selected(Character.CharacterName.Ashlyn);
    public void SelecteDamien() => Selected(Character.CharacterName.Damien);
    public void SelectedFrederick() => Selected(Character.CharacterName.Frederick);
    public void SelectedJayson() => Selected(Character.CharacterName.Jayson);
    public void SelectedJohn() => Selected(Character.CharacterName.John);
    public void SelectedKarol() => Selected(Character.CharacterName.Karol);
    public void SelectedMirianne() => Selected(Character.CharacterName.Mirianne);
    public void SelectedNikki() => Selected(Character.CharacterName.Nikki);
    public void SelectedOldCrazyMan() => Selected(Character.CharacterName.OldCrazyMan);
    public void SelectedRachel() => Selected(Character.CharacterName.Rachel);

}
