using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SoundAssets : MonoBehaviour
{
    private static SoundAssets instance;
    public List<SoundAssets> SoundsObjects = new List<SoundAssets>();


    public static SoundAssets i
    {
        get
        {
            if (instance == null) 
                instance = Instantiate(Resources.Load<SoundAssets>("SoundAssets"));
            SoundsObjects.Add(instance);
            return instance;
        }
        
    }

    public BgSounds[] soundBGArray;

    [System.Serializable]
    public class BgSounds
    {
        public SoundManager.BgSound sound;
        public AudioClip audioClip;
    }

    public SoundFXClip[] soundFXClipArray;

    [System.Serializable]
    public class SoundFXClip
    {
        public SoundManager.SoundFX sound;
        public AudioClip audioClip;
    }

    private void Start()
    {
        
    }
   
}
