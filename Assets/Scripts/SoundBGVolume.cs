using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class SoundBGVolume : MonoBehaviour
{
    private AudioSource audioSource;
    void Start()
    {
       audioSource = this.GetComponent<AudioSource>(); 
    }

    public void LowerVolume(float duration)
    {
        StartCoroutine(LowerVolumeOverTime(duration));
    }

    private IEnumerator LowerVolumeOverTime(float duration)
    {
        float elapsedTime = 0;
        float startVolume = audioSource.volume;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            audioSource.volume = Mathf.Lerp(startVolume, 0f, elapsedTime / duration);
            yield return null;
        }

        audioSource.Stop();
    }
}
