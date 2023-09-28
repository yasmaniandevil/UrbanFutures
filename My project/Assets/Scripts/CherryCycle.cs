using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryCycle : MonoBehaviour
{
    private SpriteRenderer[] _sprites; //array to store the sprites
    private int currentIndex = 0; //current index of sprites set at zero
    private int numSprites; //the number of sprites

    public static AudioSource _cherryAudio1;
    /*public AudioSource _cherryAudio2;
    public AudioSource _cherryAudio3;
    public AudioSource _cherryAudio4;
    public AudioSource _cherryAudio5;*/


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
            _sprites[currentIndex].color = new Color(1f, 1f, 1f, 0f);
            //Debug.Log("set transparent");

            //storing int variable = (0 + 1)
            //increments current index by adding 1, wraps around
            currentIndex = (currentIndex + 1) % numSprites;

            //get the array of sprite renderes and the number on the list and their color
            //set to new color where alpha is one
            _sprites[currentIndex].color = new Color(1f, 1f, 1f, 1f);
            //Debug.Log("set opaque");
            
            Debug.Log("Alpha of: " + _sprites[currentIndex].color);
        }

        /*if (currentIndex == 1)
        {
            _cherryAudio1.Play();
            Debug.Log("audio1played");
        } else if (currentIndex == 3)
        {
            _cherryAudio1.Pause();
            _cherryAudio2.Play();
            Debug.Log("audio2played");
        }else if (currentIndex == 5)
        {
            _cherryAudio2.Pause();
            _cherryAudio3.Play();
            Debug.Log("audio3played");
        }else if (currentIndex == 7)
        {
            _cherryAudio3.Pause();
            _cherryAudio4.Play();
            Debug.Log("audio4played");
        }else if (currentIndex == 8)
        {
            _cherryAudio4.Pause();
            _cherryAudio5.Play();
            Debug.Log("audio5played");
        }*/
    }
    
    //on trigger enter play audio source
    //button that is active on the texts with sprites
    //If sprite and this sprite is active
    //set button active
    //on button click
    //pause audio
    
    
    
}
