using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.Serialization;

public class BackgroundMusic : MonoBehaviour
{
    private AudioSource backgroundMusic;
    public CherryCycle cherry;
    [FormerlySerializedAs("audio")] public AudioScript liadAudio;
    public AudioScript visnhuAudio;
    public AudioScript care1;
    public AudioScript care2;
    public AudioScript care3;
    

    // Start is called before the first frame update
    void Start()
    {
        backgroundMusic = GetComponent<AudioSource>();
        backgroundMusic.Play();

    }

    // Update is called once per frame
    void Update()
    {
        if (cherry.PlayerInside == true || liadAudio.playerEntered == true)
        {
            Debug.Log(cherry.PlayerInside);
            Debug.Log(liadAudio.playerEntered);
            backgroundMusic.Pause();
        }
        else
        {
            backgroundMusic.UnPause();
        }
    }
}
