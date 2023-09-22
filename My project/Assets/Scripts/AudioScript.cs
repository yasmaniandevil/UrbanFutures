using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public static class FadeAudioSource
    {
        public static IEnumerator startFade(AudioSource audioSource, float duration, float targetVolume)
        {
            float currentTime = 0;
            float start = audioSource.volume;
            while (currentTime < duration)
            {
                currentTime += Time.deltaTime;
                audioSource.volume = Mathf.Lerp(start, targetVolume, currentTime / duration);
                yield return null;
            }
            
            yield break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(FadeAudioSource.startFade(audioSource, 3, .1f));
        Debug.Log("current volume " + audioSource.volume);
    }
}
