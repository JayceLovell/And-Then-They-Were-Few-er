using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PromoController : MonoBehaviour
{
    public float idleTimeThreshold = 30f; // time in seconds before video plays
    private float idleTimeCounter = 0f;
    bool isPlayingPromo;
    private int promoSceneIndex;
    
    void Update()
    {
        // check if player is idle
        if (Mouse.current.delta.IsActuated() || Keyboard.current.anyKey.IsActuated())
        {
            idleTimeCounter = 0f;
        }
        else
        {
            idleTimeCounter += Time.deltaTime;
        }

        // check if it's time to play the video
        if (idleTimeCounter >= idleTimeThreshold && !isPlayingPromo)
        {
            isPlayingPromo = true;
            SceneManager.LoadScene("Promo Trailer", LoadSceneMode.Additive);
            promoSceneIndex = SceneManager.GetSceneByName("Promo Trailer").buildIndex;
            GameObject.Find("BgSound").GetComponent<SoundBGVolume>().LowerVolume(1f);
            SceneManager.SetActiveScene(                
                    SceneManager.GetSceneByBuildIndex(promoSceneIndex));            
        }
    }

    void LateUpdate()
    {
        // check if player has input and unload the scene
        if (isPlayingPromo && (Mouse.current.delta.IsActuated() || Keyboard.current.anyKey.IsActuated()))
        {
            isPlayingPromo = false;
            SceneManager.UnloadSceneAsync("Promo Trailer");
            GameObject.Find("BgSound").GetComponent<AudioSource>().volume = GameManager.Instance.BgmVolume;
            promoSceneIndex = -1;
            idleTimeCounter = 0f;
        }
    }
}