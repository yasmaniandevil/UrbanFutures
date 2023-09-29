using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;

public class AudioScript : MonoBehaviour
{
    public AudioSource audioSource;
    public Button button;
    private bool playerEntered = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        //GameObject.FindWithTag("Player");


    }
    /*public static class FadeAudioSource
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
    }*/

    // Update is called once per frame
    void Update()
    {
        //StartCoroutine(FadeAudioSource.startFade(audioSource, 100, .1f));
        //Debug.Log("current volume " + audioSource.volume);
        
        if (Input.GetKey(KeyCode.Q))
        {
            Debug.Log("Q clicked");
            audioSource.Pause();
            Debug.Log("audio paused");
        }
        
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerEntered = true; // Player has entered the trigger area
            PlayAudioIfPlayerEntered();
            Debug.Log("player entered set to true");
            Debug.Log("Player entered the trigger area");
        }
    }
    
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerEntered = false; // Player has exited the trigger area
            audioSource.Pause();
            Debug.Log("player entered set to false");
            Debug.Log("Player exited the trigger area");
        }
    }

    /*public void PauseButton()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Pause();
            Debug.Log("Liad audio paused");
        }
    }*/
    
    void PlayAudioIfPlayerEntered()
    {
        if (playerEntered == true)
        {
            Debug.Log("PlauAudioEntered");
            audioSource.Play();
            Debug.Log("Audio source" +audioSource.name);
            Debug.Log("Audio played because player is in the trigger area");
        }
    }
    
    
    
}
