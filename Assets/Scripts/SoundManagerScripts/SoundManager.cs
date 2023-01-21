using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SoundManager
{
    //To handle multiple sounds
    public enum SoundFX
    {
        PlayerWalk,
        UseDoor,
        MenuSelect
       
    }
    public enum BgSound
    {
        Title,
        Background,
        GameWon,
        GameLost,
        MainMenu,
        Interigation
    }

    public static void StartBackground(BgSound bgSound)
    {
        GameObject bgsoundGameObject = new GameObject("BgSound");
        AudioSource audioSource = bgsoundGameObject.AddComponent<AudioSource>();
        audioSource.PlayOneShot(GetBGAudio(bgSound));
        audioSource.loop = true;
        audioSource.volume= GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().BGMusicVolume;
    }
    /// <summary>
    /// Grabs Enum audio and plays once
    /// </summary>
    /// <param name="sound"></param>
    public static void PlaySound(SoundFX sound)
    {
        GameObject soundGameObject = new GameObject("SoundFX");
        AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();
        audioSource.PlayOneShot(GetAudio(sound));
        audioSource.volume = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().SfxVolume;
        soundGameObject.AddComponent<SoundFXLife>().SoundLength=GetAudio(sound).length;
    }
    private static AudioClip GetBGAudio(BgSound sound)
    {
        foreach (SoundAssets.BgSounds Bgsound in SoundAssets.i.soundBGArray)
        {
            if (Bgsound.sound == sound)
            {
                return Bgsound.audioClip;
            }
        }
        Debug.LogError("Sound" + sound + "not found");
        return null;
    }
    /// <summary>
    /// Gets audio clip from sound assets
    /// </summary>
    /// <param name="sound"></param>
    /// <returns></returns>
    private static AudioClip GetAudio(SoundFX sound)
    {
        foreach (SoundAssets.SoundFXClip soundFxClip in SoundAssets.i.soundFXClipArray)
        {
            if (soundFxClip.sound == sound)
            {
                return soundFxClip.audioClip;
            }
        }
        Debug.LogError("Sound" + sound + "not found");
        return null;
    }
}
