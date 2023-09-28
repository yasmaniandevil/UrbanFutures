using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryAudio : MonoBehaviour
{

    //private CherryCycle _cherryScript;
    //public GameObject _NextCherry;
    public static AudioSource _cherryAudio1;
    
    private void Start()
    {
        GameObject audioObject = GameObject.FindWithTag("CherryAudio1");

        if (audioObject != null)
        {
            _cherryAudio1 = audioObject.GetComponent<AudioSource>();
        }
        else
        {
            Debug.Log("couldntfindaudio");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
        Debug.Log("triggered entered");
        _cherryAudio1.Play();
    }
    
}
