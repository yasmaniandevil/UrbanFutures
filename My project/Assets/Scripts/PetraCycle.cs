using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetraCycle : MonoBehaviour
{
     //array to store objects to cycle
    private GameObject[] _marinaToCycle;
    //index of currently visable obj
    private int currentIndex = 0;
    //number of objects
    private int numObjects;
    private bool playerInside = false;
    
    // Start is called before the first frame update
    void Start()
    {
        //find gameobj with the tags and store it in objectsToCycle
        _marinaToCycle = GameObject.FindGameObjectsWithTag("PetraCycle");
        //count the length of the objs to cycle legth store in num objects
        numObjects = _marinaToCycle.Length;

        //Set the alpha of all objects except the first one to 0, making them transparent
        for (int i = 1; i < numObjects; i++)
        {
            //
            SetAlpha(_marinaToCycle[i], 0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInside)
        {
            Debug.Log("Petra Entered");
            //if e is pressed
            if (Input.GetKeyDown(KeyCode.E))
            {
            
                //set alpha of currently visible obj to 0
                SetAlpha(_marinaToCycle[currentIndex], 0f);
                //Debug.Log("TransparentSpriteNo:" +currentIndex);
                //index goes up by one
                currentIndex = (currentIndex + 1) % numObjects;
                Debug.Log("current index:" + currentIndex);
                //set alpha of next obj in array to 1
                SetAlpha(_marinaToCycle[currentIndex], 1f);
                //Debug.Log("Sprite ON:" +currentIndex);
            }
        }
        
    }

    private void SetAlpha(GameObject parent, float alpha)
    {
        //get all mesh renderers in the parent obj and its children
        MeshRenderer[] meshRender = parent.GetComponentsInChildren<MeshRenderer>();
        
        
        /*It declares a variable meshRenderer of type MeshRenderer that represents
         each element in the meshRender array as it iterates through it.
         Inside the loop, you can access and manipulate each MeshRenderer component individually.*/
        
        //loop through each mesh renderer
            foreach (MeshRenderer meshRenderer in meshRender)
            {
                
                //access to individual component on the renderer stored in the meshRender variable
                //access then modify the properties or fields of the component
                //get the current color and update it alpha component
                
                //retrives current color of material
                Color color = meshRenderer.material.color;
                //updates in alpha
                color.a = alpha;
                //assigns modified color back
                meshRenderer.material.color = color;
            }

            SpriteRenderer[] spriteRenderers = parent.GetComponentsInChildren<SpriteRenderer>();
            foreach (SpriteRenderer spriteRenderer in spriteRenderers)
            {
                Color color = spriteRenderer.material.color;
                color.a = alpha;
                spriteRenderer.color = color;
            }
        
        //Debug.Log("Alpha of " + parent.name + "is now" + alpha);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = false;
        }
    }
}
