using System;
using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class FadeGameObject : MonoBehaviour
{
    private Renderer objectRenderer;
    private Color originalColor;
    
    // Start is called before the first frame update
    void Start()
    {
        //get renderer component from gameobj
        objectRenderer = GetComponent<Renderer>();

        //store the original color (including alpha)
        originalColor = objectRenderer.material.color;
    }

    void FadeIn()
    {
        Color newColor = originalColor;
        newColor.a = 1f;
        objectRenderer.material.color = newColor;
        Debug.Log(newColor);
    }

    void FadeOut()
    {
        Color newColor = originalColor;
        newColor.a = 0f;
        objectRenderer.material.color = newColor;
        Debug.Log(newColor);
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
