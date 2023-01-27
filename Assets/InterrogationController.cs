using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterrogationController : MonoBehaviour
{
    private GameManager _gameManager;
    [SerializeField]
    private Sprite _interrogationNPC;

    public GameObject PlayerPrefab;

    public SpriteRenderer NPCSprite;

    public Sprite InterrogationNPC
    {
        get { return _interrogationNPC;}
        set { _interrogationNPC = value;}
    }


    // Start is called before the first frame update
    void Start()
    {
        // _gameManager = GameManager.Instance;
        NPCSprite.sprite = InterrogationNPC;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
