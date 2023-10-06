using System;
using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;

public class AudioScript : MonoBehaviour
{
    public AudioSource audioSource;
    public bool playerEntered = false;
    private bool isPaused = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

// Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.Q))
        {
            TogglePause();
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
            audioSource.Stop();
            Debug.Log("player entered set to false");
            Debug.Log("Player exited the trigger area");
        }
    }
    
    void TogglePause()
    {
        if (isPaused)
        {
            audioSource.UnPause();
            isPaused = false;
            Debug.Log("Audio resumed");
        }
        else
        {
            audioSource.Pause();
            isPaused = true;
            Debug.Log("Audio paused");
        }
    }

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
