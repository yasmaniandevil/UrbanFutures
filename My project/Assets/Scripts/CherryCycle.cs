using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CherryCycle : MonoBehaviour
{
    private SpriteRenderer[] _sprites; //array to store the sprites
    private static int currentIndex = 0; //current index of sprites set at zero
    private int numSprites; //the number of sprites

    //array of audio clips
    public AudioClip[] audioClips;
    //variable of audio source
    private AudioSource _audioSource;

    //array of the list of buttons
    public Button pauseButton;
    
    // Start is called before the first frame update
    void Start()
    {
        //get children on game object sprite renderers and
        //store it in sprites which is an array
        _sprites = GetComponentsInChildren<SpriteRenderer>();
        //the length of the sprites store that number into the amount of sprites
        numSprites = _sprites.Length;

        //hide all the sprites but the first sprite
        //set their alpha to zero
        //i euqal's 1, and 1 is less than the total number of
        //sprites(9) than go to the next part of the list
        for (int i = 1; i < numSprites; i++)
        {
            //all renderers of children, their color equals
            // new color where the alpha is set to zero
            _sprites[i].color = new Color(1f, 1f, 1f, 0f);
        }

        _audioSource = GetComponent<AudioSource>();
            
        pauseButton.onClick.AddListener(() => onPauseButtonClick());
    }

    // Update is called once per frame
    void Update()
    {
        //if you click the right arrow
        if (Input.GetKeyDown(KeyCode.E))
        {
            //get the array of sprite renderes and the number on the list and their color
            //set to new color where alpha is zero
            //Debug.Log("key pressed");
            //_sprites[currentIndex].color = new Color(1f, 1f, 1f, 0f);
            //Debug.Log("set transparent");
            
            Debug.Log("Alpha of: " + _sprites[currentIndex].color);
            
            switch (currentIndex)
            {
                case 0:
                    _audioSource.clip = audioClips[0];
                    _audioSource.Play();
                    break;
                case 2:
                    _audioSource.Pause();
                    _audioSource.clip = audioClips[1];
                    _audioSource.Play();
                    break;
                case 4:
                    _audioSource.Pause();
                    _audioSource.clip = audioClips[2];
                    _audioSource.Play();
                    break;
                case 6:
                    _audioSource.Pause();
                    _audioSource.clip = audioClips[3];
                    _audioSource.Play();
                    break;
                default:
                    Debug.Log("DEFAULT");
                    break;
            }
            
            //storing int variable = (0 + 1)
            //increments current index by adding 1, wraps around
            currentIndex = currentIndex + 1;

            //get the array of sprite renderes and the number on the list and their color
            //set to new color where alpha is one
            _sprites[currentIndex].color = new Color(1f, 1f, 1f, 1f);
            //Debug.Log("set opaque");
            
        }
        
    }

    public void onPauseButtonClick()
    {
        //check if audio source is playing and matches buttons assignment
        if (_audioSource.isPlaying)
        {
            _audioSource.Pause();
        }
    }
    
    //on trigger enter play audio source
    //button that is active on the texts with sprites
    //If sprite and this sprite is active
    //set button active
    //on button click
    //pause audio
    
    
    
}
