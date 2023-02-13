using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class SoundBGVolume : MonoBehaviour
{
    void Update()
    {
        GetComponent<AudioSource>().volume = (GameManager.Instance.BgmVolume/100);
    }
}
