using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryAudioManager : MonoBehaviour
{
    
    public AudioSource _cherryAudio2;
    public AudioSource _cherryAudio3;
    public AudioSource _cherryAudio4;
    public AudioSource _cherryAudio5;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TurnOffAudio()
    {
        CherryAudio._cherryAudio1.Pause();
        Debug.Log("audio paused");
    }
}
