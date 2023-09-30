using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextSprite : MonoBehaviour
{
    private SpriteRenderer[] _sprites; //array to store the sprites
    private int currentIndex = 0; //current index of sprites set at zero
    private int numSprites; //the number of sprites
    private bool playerInsideTrigger = false;


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
        if (playerInsideTrigger)
        {
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
            }
        }
        //if you click the right arrow
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInsideTrigger = true; // Set the flag to indicate the player is inside the trigger area
        }
    }

    // OnTriggerExit is called when the player exits the trigger area
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInsideTrigger = false; // Set the flag to indicate the player has exited the trigger area
        }
    }
}
