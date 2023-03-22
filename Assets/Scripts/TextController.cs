using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    private GameManager _gameManager;
    private int _numTextToDisplay = 0;
    [SerializeField]
    private float _textSpeed = 0.1f;
    private bool _isFinishDisplayText;

    private string GameWonText;
    private string TimeOutText;
    private string IntroText;
    private string DefaultLoseText;

    public TextMeshProUGUI DisplayText;
    public Button OkButton;

    public List<String> BeforeMurderText;
    public List<String> AfterMurderText;

    public List<GameOverText> GameOverTexts;

    void Awake()
    {
        _gameManager = GameManager.Instance;
    }
    // Start is called before the first frame update
    void Start()
    {
        LoadText();
        OkButton.interactable = false;
        _isFinishDisplayText = false;
        switch (_gameManager.PlayerProgress)
        {
            case GameManager.GameState.NewGame:
                StartCoroutine(PrintText(IntroText));
                _gameManager.PlayerProgress = GameManager.GameState.BeforeMurder;
                break;
            case GameManager.GameState.BeforeMurder:
                StartCoroutine(PrintText(AfterMurderText[_numTextToDisplay]));
                _gameManager.PlayerProgress = GameManager.GameState.AfterMurder;
                _numTextToDisplay++;
                break;
            case GameManager.GameState.GameWon:
                StartCoroutine(PrintText(GameWonText));               
                break;
            case GameManager.GameState.TimeOut:
                StartCoroutine(PrintText(TimeOutText));               
                break;
            case GameManager.GameState.WrongPerson:
                foreach (GameOverText gameOverText in GameOverTexts)
                {
                    try
                    {
                        if (gameOverText.SelectCharacterName == _gameManager.Chosen)
                        {
                            StartCoroutine(PrintText(gameOverText.text));
                            break;
                        }
                    }
                    catch
                    {
                        Debug.LogWarning("Something went wrong in finding Chosen so playing default lose text");
                        StartCoroutine(PrintText(DefaultLoseText));
                    }
                }
                break;
            default:
                Debug.LogError("Didn't hit a enum in TextController at Start");
                break;
        }        
    }
    /// <summary>
    /// loads all text needed.
    /// Maybe in future load this from text instead.
    /// </summary>
    private void LoadText()
    {
        // Create Intro To Game Text
        IntroText = "Ashlyn Hunt, our intrepid detective, has been invited by her friend Nikki Test to her invention showcase. \r\n\r\nAshlyn arrives, and is welcomed by Watson, Nikki's robot butler. \r\n\r\nWith Ashlyn being the last guest to arrive, Watson makes his departure, and Ashlyn goes on to interact with the other guests...";

        // Game Won text
        GameWonText = "Ashlyn took a deep breath. The clues, the interrogations, they had all led to this moment. " +
            "She now knew the identity of Nikki's murderer. And yet..." + "\r\n\r\n\"It was Rachel. She murdered Nikki!\" Ashlyn says, to the astonishment and disbelief of the other guests." + "\r\n\r\nRachel sighs, stands up, and slowly nods her head as she begins to sob." +
            "\r\n\r\nRachel tearfully explains how she and Nikki had got into an argument about Nikki joining the family business, after the showcase. In a fit of anger, Rachel had pushed Nikki and she hit her head, dying due to blood loss." +
            "\r\n\r\nOnce the storm clears, Rachel is escorted by Ashlyn and the Mayor to the Police Station. Rachel is remorseful and accepts her fate..." +
            "\r\n\r\nRACHEL IS THE MURDERER";

        // Game Time Out
        TimeOutText = "Ashlyn was unable to deduce the identity of the murderer. \r\n\r\nThe storm outside clears up, but the tempest of unsatisfaction within Ashlyn's soul will never stop, knowing that Nikki's murderer will never be brought to justice...";

        // Default lose text
        DefaultLoseText = "Ashlyn makes the wrong deduction and accuses the wrong person. Her and the Mayor escort them to the station, as they protest violently that they didn�t do it. They are convicted of the crime and go to jail. Ashlyn later receives an anonymous letter from the real murderer, who says that while they are glad they were not caught, they regret what they did.\r\n";

        // Before Murder Text
        /*BeforeMurderText.Add("After talking to each of the other guests, the showcase begins.\r\n\r\nNikki is able to display her invention, the synthesizer, and everyone is impressed.\r\n\r\nLater on, after the showcase�\r\n");
        BeforeMurderText.Add("The guests had been invited to sleepover at the mansion after the showcase. They all go to bed, except for Nikki and Watson, who stay behind to clean up. As the night goes on, a thunderstorm begins to rage...");*/

        // After Murder Text
		
		AfterMurderText.Add("After talking to each of the other guests, the showcase begins.\r\n\r\nNikki is able to display her invention, the synthesizer, and everyone is impressed.\r\n\r\nLater on, after the showcase�\r\n");
        AfterMurderText.Add("The guests had been invited to sleepover at the mansion after the showcase. They all go to bed, except for Nikki and Watson, who stay behind to clean up. As the night goes on, a thunderstorm begins to rage...");
        AfterMurderText.Add("An hour or so after the showcase, everyone has gone to sleep. The storm continues to rage outside.\r\n\r\nA clap of thunder wakes Ashlyn up. She decides to grab a glass of milk\r\n\r\nShe happens to pass by the lab, which has the door ajar\r\n\r\nPeeking inside, she sees Nikki lying on the floor...");
        AfterMurderText.Add("Ashlyn runs in and finds that Nikki is dead.\r\n\r\nShe mourns for her friend, and looks around the room.\r\n\r\nShe notices a bloody pipe in the corner of the room.\r\n\r\nSeeing nothing else, she leaves to announce the death of Nikki Test...");
        AfterMurderText.Add("Ashlyn announces her discovery to the shock of the other guests.\r\n\r\nThe storm prevents them from leaving to go to the police.\r\n\r\nAshlyn decided to investigate and get to the bottom of the gruesome murder...");

        // Create GameOver on which character selected
        GameOverText Ashlyn = new GameOverText();
        Ashlyn.SelectCharacterName = Character.CharacterName.Ashlyn;
        Ashlyn.text = "Ashlyn took a deep breath. The clues, the interrogations, they had all led to this moment. She now knew the identity of Nikki's murderer. And yet..." +
            "\r\n\r\n\"It's me. I murdered Nikki\" Ashlyn says, to the astonishment and disbelief of the other guests." +
            "\r\n\r\nShe allows Frederick to handcuff her and is escorted out of the mansion.\r\n\r\nAs she is taken to the police station, Ashlyn reflects on the events of the night. " +
            "\r\n\r\nOf course, she wasn't the true murderer, but to reveal their true identity... She would never know what their true motive was, but Ashlyn's discovery of their identity would haunt her for a very long time... ";
        GameOverTexts.Add(Ashlyn);
		
		GameOverText Damien = new GameOverText();
        Damien.SelectCharacterName = Character.CharacterName.Damien;
        Damien.text = "Damien Placeholder Ending ";
        GameOverTexts.Add(Damien);
		
		GameOverText Fredrick = new GameOverText();
        Fredrick.SelectCharacterName = Character.CharacterName.Frederick;
        Fredrick.text = "Ashlyn took a deep breath. The clues, the interrogations, they had all led to this moment. " +
            "She now knew the identity of Nikki's murderer. " + "\r\n\r\n\"It was the Mayor. He murdered Nikki!\" Ashlyn says, to the astonishment and disbelief of the other guests." + "\r\n\r\nFrederick faints in shock." +
            "\r\n\r\nOnce Frederick has been woken up, Ashlyn explains how she deduced that Frederick at one point had the keys to Nikki's lab, and how he tried to flush them down the toilet, but was overheard by John and his father. " +
            "\r\n\r\nFrederick admits to having stolen the keys from Watson, but denies any part in Nikki's murder, and insists that he was unaware she was dead until Ashlyn had announced her discovery later that night. " +
            "\r\n\r\nFrederick goes on to explain how he had managed to steal the keys from Watson after the showcase, and had intended to sneak into the lab to steal Nikki's notes on the synthesizer." +
            "Frederick's plan was to photocopy the notes, and have government funded scientists develop their own version, so that the town council could cut Nikki out of the picture and avoid having to pay her for her work. " +
            "\r\n\r\n\"We just didn't have enough money in the town budget to pay Nikki... All the money was spent on my re-election campaign!\" , Frederick said sheepishly." +
            "\r\n\r\nHe had tried getting in the lab later that night, but on his way there he saw Mirianne leaving the room. In that moment he panicked, and ran to the toilet to try to hide, dropping the keys in the stall in his confusion." +
            "\r\n\r\nThe storm eventually clears. Frederick is escorted by Ashlyn and Jayson to the Police Station to have his statement taken, however... " +
            "\r\n\r\nFREDERICK IS NOT THE MURDERER";
        GameOverTexts.Add(Fredrick);
		
		GameOverText Jayson = new GameOverText();
        Jayson.SelectCharacterName = Character.CharacterName.Jayson;
        Jayson.text = "Okay. You and I both know Jayson didn't do it. " +
            "\r\n\r\nUnfortunately, you're going to have to replay the game to find out who did...Sorry! " +
            "\r\n\r\nJAYSON IS NOT THE MURDERER ";
        GameOverTexts.Add(Jayson);
		
		GameOverText John = new GameOverText();
        John.SelectCharacterName = Character.CharacterName.John;
        John.text = "John Placeholder Ending ";
        GameOverTexts.Add(John);
		
		GameOverText Karol = new GameOverText();
        Karol.SelectCharacterName = Character.CharacterName.Karol;
        Karol.text = "Karol Placeholder Ending ";
        GameOverTexts.Add(Karol);
		
		GameOverText Mirianne = new GameOverText();
        Mirianne.SelectCharacterName = Character.CharacterName.Mirianne;
        Mirianne.text = "Ashlyn took a deep breath. The clues, the interrogations, they had all led to this moment. " +
            "She now knew the identity of Nikki's murderer. " + "\r\n\r\n\"It was Mirianne. She murdered Nikki!\" Ashlyn says, to the astonishment and disbelief of the other guests." + "\r\n\r\nMirianne stands up furiously, and denies it all." +
            "\r\n\r\nMirianne protests that while she did indeed know that Nikki had been killed prior to Ashlyn's announcement, she was not the one to do it. " +
            "\r\n\r\nAccording to Mirriane, that night she happened to be passing by the lab, only to discover Nikki on the floor, and bleeding heavily. " +
            "She rushed to her body to try to stop the bleeding with a handkerchief that was lying on the ground nearby, but it was already too late." +
            "\r\n\r\nMirianne insists that her fear of being suspected of the murder is the reason she did not raise the alarm. " +
            "\r\n\r\nAs the storm clears, Mirianne is escorted by Ashlyn and the Mayor to the Police Station to have her statement taken, however... " +
            "\r\n\r\nMIRIANNE IS NOT THE MURDERER"; 
        GameOverTexts.Add(Mirianne);
		

		GameOverText OCM = new GameOverText();
        OCM.SelectCharacterName = Character.CharacterName.OldCrazyMan;
        OCM.text = "OCM Placeholder Ending ";
        GameOverTexts.Add(OCM);

		
		GameOverText Rachel = new GameOverText();
        Rachel.SelectCharacterName = Character.CharacterName.Rachel;
        Rachel.text = "RAKKELL" /*"Ashlyn took a deep breath. The clues, the interrogations, they had all led to this moment. " +
            "She now knew the identity of Nikki's murderer. And yet..." + "\r\n\r\n\"It was Rachel. She murdered Nikki!\" Ashlyn says, to the astonishment and disbelief of the other guests." + "\r\n\r\nRachel sighs, stands up, and slowly nods her head as she begins to sob." +
            "\r\n\r\nRachel tearfully explains how she and Nikki had got into an argument about Nikki joining the family business, after the showcase. In a fit of anger, Rachel had pushed Nikki and she hit her head, dying due to blood loss." +
            "\r\n\r\nOnce the storm clears, Rachel is escorted by Ashlyn and the Mayor to the Police Station. Rachel is remorseful and accepts her fate..." +
            "\r\n\r\nRACHEL IS THE MURDERER"*/;
        GameOverTexts.Add(Rachel);

        GameOverText Robot = new GameOverText();
        Robot.SelectCharacterName = Character.CharacterName.Robot;
        Robot.text = "Ashlyn took a deep breath. The clues, the interrogations, they had all led to this moment. " +
            "\r\n\r\nShe walks over to the de-activated Wattson, Nikki's robot butler. " +
            "\r\n\r\n\"Please re-activate him\" Ashlyn says to Damien, who looks puzzled." + "\"I believe he's the key to all of this.\"" +
            "\r\n\r\nThough looking doubtful, Damien approaches Wattson and gets to work. The rest of the household watches silently as Damien tinkers with Wattson's open chestboard." +
            "\r\n\r\nIt takes some time, but Damien is eventually able to get Wattson semi-operational, at least to a point where he can talk." +
            "\r\n\r\n\"I know who did it. I know who killed Mistress Nikki\"  Wattson says, his damaged voicebox making his voice sound distorted and ominous." +
            "\r\n\r\nSuddenly, there is a flash of lightning. Thunder rumbles outside." +
            "\r\n\r\n...and the lights go out." +
            "\r\n\r\nThere are a few seconds of silence, but this is soon broken by a loud crash." +
            "\r\n\r\nThere is another flash of lightning, and this lights the dark room momentarily." +
            "\r\n\r\nSomebody screams. For, in that brief flash of light, Wattson's now mangled head becomes visible. " +
            "\r\n\r\nThe lights turn back on, and the rest of the household is able to properly view Wattson. His body has been destroyed." +
            "\r\n\r\nIt seems, in that moment of darkness, someone used the opportunity to silence Wattson." +
            "\r\n\r\nAshlyn looks around at the other guests, who are all seemingly quite as shocked as she is. Not knowing what to say, she turns to the window, where the storm continues to rage outside..." +
            "\r\n\r\nWATTSON IS SILENCED";
        GameOverTexts.Add(Robot);
    }
    /// <summary>
    /// When ever the Ok button is pressed or E is pressed this method is called.
    /// </summary>
    public void OnNext()
    {
        if (_isFinishDisplayText)
        {
            switch (_gameManager.PlayerProgress)
            {
                case GameManager.GameState.NewGame:
                    Debug.LogWarning("Shouldn't be here");
                    break;
                case GameManager.GameState.BeforeMurder:
                    try
                    {
                        StartCoroutine(PrintText(BeforeMurderText[_numTextToDisplay]));
                    }
                    catch
                    {

                        SceneManager.LoadScene("Entrance");
                    }
                    break;
                case GameManager.GameState.AfterMurder:
                    try
                    {
                        StartCoroutine(PrintText(AfterMurderText[_numTextToDisplay]));
                    }
                    catch
                    {
                        SceneManager.LoadScene("GrandHall");
                    }
                    break;
                case GameManager.GameState.GameWon:
                case GameManager.GameState.TimeOut:
                case GameManager.GameState.WrongPerson:
                    SceneManager.LoadScene("Title");
                    PlayerPrefs.DeleteAll();
                    break;
                default:
                    Application.Quit();
                    break;
            }
            _numTextToDisplay++;
        }
        else
            _textSpeed--;
    }
    IEnumerator PrintText(string text)
    {
        DisplayText.text = "";
        OkButton.interactable = false;
       _isFinishDisplayText = false;
        foreach (char c in text)
        {
            DisplayText.text += c;
            yield return new WaitForSeconds(_textSpeed);
        }
        _textSpeed = 0.1f;
        OkButton.interactable= true;
        _isFinishDisplayText = true;
    }
    [System.Serializable]
    public class GameOverText
    {
        /// <summary>
        /// Character name is case sensetive.
        /// </summary>
        public Character.CharacterName SelectCharacterName;
        /// <summary>
        /// Text to display based on person.
        /// </summary>
        public string text;
    }
}
