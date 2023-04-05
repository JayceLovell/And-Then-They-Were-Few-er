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
        IntroText = "Ashlyn Hunt, our intrepid detective, has been invited by her friend Nikki Test to her invention showcase. \r\n\r\nAshlyn arrives, and is welcomed by Wattson, Nikki's robot butler. \r\n\r\nWith Ashlyn being the last guest to arrive, Wattson makes his departure, and Ashlyn goes on to interact with the other guests...";

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
        BeforeMurderText.Add("The guests had been invited to sleepover at the mansion after the showcase. They all go to bed, except for Nikki and Wattson, who stay behind to clean up. As the night goes on, a thunderstorm begins to rage...");*/

        // After Murder Text

        AfterMurderText.Add("After talking to each of the other guests, the showcase begins.\r\n\r\nNikki is able to display her invention, the synthesizer, and everyone is impressed.\r\n\r\nLater on, after the showcase...\r\n");
        AfterMurderText.Add("The guests had been invited to sleepover at the mansion after the showcase. They all depart for their bedrooms, except for Nikki and Wattson, who stay behind to clean up. As the night goes on, a thunderstorm begins to rage...");
        AfterMurderText.Add("A few hours after the showcase, everyone has seemingly gone to sleep. The storm continues to rage outside.\r\n\r\nA clap of thunder wakes Ashlyn up. She decides to grab a glass of milk.\r\n\r\nShe happens to pass by the lab, which has the door ajar.\r\n\r\nPeeking inside, she sees Nikki lying on the floor...");
        AfterMurderText.Add("Ashlyn runs in and finds that Nikki is dead.\r\n\r\nShe mourns for her friend, and looks around the room.\r\n\r\nShe notices a bloody pipe in the corner of the room.\r\n\r\nSeeing nothing else, she leaves to announce the death of Nikki Test...");
        AfterMurderText.Add("Ashlyn announces her discovery to the shock of the other guests.\r\n\r\nThe storm prevents them from leaving to go to the police.\r\n\r\nAshlyn decides to investigate and get to the bottom of the gruesome murder...");

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
        Damien.text = "Ashlyn took a deep breath. The clues, the interrogations, they had all led to this moment. " +
            "She now knew the identity of Nikki's murderer. " + "\r\n\r\n\"It was Damien. He murdered Nikki!\" Ashlyn says, to the astonishment and disbelief of the other guests." + "\r\n\r\nDamien remains silent. He stands up slowly, and extends his wrists, indicating for Ashlyn to handcuff him." +
         "\r\n\r\n\"Damien...No!\", Karol shouts, looking horrified." +
         "\r\n\r\n\"There's no way!\", Jayson says in a stunned voice." +
            "\r\n\r\nDamien continues to remain quiet, and allows himself to be handcuffed, occasionally glancing at Karol, who had turned away from him." +
            "After the storm clears, he is taken to the police station." +
            "\r\n\r\nHowever, over the next few days, the police are unable to find any physical evidence that links Damien to the murder of Nikki." +
            "\r\n\r\nA week after being taken into custody, Damien is released. As he leaves the station, he finds Jayson waiting outside." +
            "\r\n\r\nThey walk back together, and Damien confesses to Jayson that he did not murder Nikki. He took the blame because he believed someone else to have done it, but did not wish to see them imprisoned, and had decided to remain silent." +
             "\r\n\r\n\"The things one does for love...\" Jayson says, as he shakes his head. " +
             "\r\n\r\nThey continue down the path in silence. Unbeknownst to the two young men, Ashlyn is silently tailing them from behind, listening. She has her doubts, but it becomes clear that..." +
            "\r\n\r\nDAMIEN IS NOT THE MURDERER";
        GameOverTexts.Add(Damien);

        GameOverText Fredrick = new GameOverText();
        Fredrick.SelectCharacterName = Character.CharacterName.Frederick;
        Fredrick.text = "Ashlyn took a deep breath. The clues, the interrogations, they had all led to this moment. " +
            "She now knew the identity of Nikki's murderer. " + "\r\n\r\n\"It was the Mayor. He murdered Nikki!\" Ashlyn says, to the astonishment and disbelief of the other guests." + "\r\n\r\nFrederick faints in shock." +
            "\r\n\r\nOnce Frederick has been woken up, Ashlyn explains how she deduced that Frederick at one point had the keys to Nikki's lab, and how he tried to flush them down the toilet, but was overheard by John and his father. " +
            "\r\n\r\nFrederick admits to having stolen the keys from Wattson, but denies any part in Nikki's murder, and insists that he was unaware she was dead until Ashlyn had announced her discovery later that night. " +
            "\r\n\r\nFrederick goes on to explain how he had managed to steal the keys from Wattson after the showcase, and had intended to sneak into the lab to steal Nikki's notes on the synthesizer." +
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
        John.text = "Okay. You and I both know John didn't do it. The only crime he's committed is poor toilet protocol." +
            "\r\n\r\nUnfortunately, you're going to have to replay the game to find out who did...Sorry! " +
            "\r\n\r\nJOHN IS NOT THE MURDERER ";
        GameOverTexts.Add(John);

        GameOverText Karol = new GameOverText();
        Karol.SelectCharacterName = Character.CharacterName.Karol;
        Karol.text = "Ashlyn took a deep breath. The clues, the interrogations, they had all led to this moment. " +
            "She now knew the identity of Nikki's murderer. " + "\r\n\r\n\"It was Karol. She murdered Nikki!\" Ashlyn says, to the astonishment and disbelief of the other guests." + "\r\n\r\nKarol rises angrily. As she opens her mouth to speak, Damien too stands up, and raises his hand to cut her off." +
         "\r\n\r\n\"It wasn't Karol... It was I that murdered Nikki\", Damien says gravely." +
            "\r\n\r\nEveryone is stunned. Karol, in particular, looks shocked, but remains quiet." +
            "\r\n\r\nAshlyn is taken aback by this confession, but seeing the look of grim resignation on Damien's face, nods to Frederick, and they handcuff Damien." +
            "After the storm clears, Damien is taken to the police station." +
            "\r\n\r\nHowever, over the next few days, despite his confession, the police are unable to find any physical evidence that links either Karol or Damien to the murder of Nikki." +
            "\r\n\r\nA week after being taken into custody, Damien is released. As he leaves the station, he finds Karol waiting outside." +
            "\r\n\r\nThey walk back together, and Damien confesses to Karol that he took the blame for the murder because he believed Karol to have done it, but due to his love for her, did not wish to see her imprisoned." +
             "\r\n\r\nKarol grabs Damien by the shoulders and tearfully looks him straight in the face." +
             "\r\n\r\n\"Damien, I-I swear to you, I didn't murder Nikki!\". " +
             "\r\n\r\nThere is a long silence, as Damien stares back at Karol, desperately searching her face for the truth. After a few minutes, he slowly nods his head, and they embrace." +
             "\r\n\r\nUnbeknowst to both of them, Ashlyn is lurking in the shadows nearby, watching. She has her doubts, but seeing them together, it becomes clear that..." +
            "\r\n\r\nKAROL IS NOT THE MURDERER";
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

        //Resending
        GameOverText OCM = new GameOverText();
        OCM.SelectCharacterName = Character.CharacterName.OldCrazyMan;
        OCM.text = "Ashlyn took a deep breath. The clues, the interrogations, they had all led to this moment. " +
            "She now knew the identity of Nikki's murderer. " + "\r\n\r\n\"It was... him!\" Ashlyn says, as she points at John's father, the Old Crazy Man. " +
         "\r\n\r\n\"NOW WAIT JUST A MINUTE!\"  he shouts, looking startled." +
         "\r\n\r\n\"I know what this is about! You just want to frame me and get me locked up! That way, the gears will be yours for the taking! Well, you can't have them!\"" +
            "\r\n\r\nIn a manic state, the old man rushes to the other side of the room and jumps straight through the window, smashing the glass." +
            "\r\n\r\nThere is a moment of stunned shock and silence, before everyone rushes outside to attempt to catch him." +
            "\r\n\r\nHowever, they find him right outside the window, lying unconscious in the grass. The Old Fool had been knocked out in his attempt to fling himself out the window." +
            "\r\n\r\nA week later, the Old Man is released from the hospital. During his stay there, he had been interviewed by the police, but it soon became very clear that he had nothing to do with Nikki's murder." +
            "\r\n\r\nTHE OLD CRAZY MAN IS NOT THE MURDERER";
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
        OkButton.interactable = true;
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