using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public AudioSource backgroundMusic;
    

    // Start is called before the first frame update
    void Start()
    {
        backgroundMusic = GetComponent<AudioSource>();
        

    }

    // Update is called once per frame
    void Update()
    {
        if (IsOtherAudioPlaying())
        {
            backgroundMusic.Pause();
        }
        else
        {
            backgroundMusic.Play();
        }


        bool IsOtherAudioPlaying()
        {

            return false;
        }    
    }
}
