using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeGameObject : MonoBehaviour
{
    
    private Renderer _objectRender;
    private Color _originalColor;
    /*private Color _targetColor;
    private float fadeDuration = 1f;
    private float currentTime = 0f;
    private bool isFading = false;*/
    
    // Start is called before the first frame update
    void Start()
    {
        //get the renderer component of the gameObject
        _objectRender = GetComponent<Renderer>();

        //store original color including alpha
        _originalColor = _objectRender.material.color;
        
        //set the target color with the same
        //RGB values as the original but set alpha to zero
        //_targetColor = new Color(_originalColor.r,
           //_originalColor.g, _originalColor.b, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //check if the obj is currently fading
        /*if (isFading)
        {
            currentTime += Time.deltaTime;

            //clamp01 clamps value between 1 n 0
            //calculate the lerp factor
            float lerpFactor = Mathf.Clamp01(currentTime / fadeDuration);

            //set lerped value to a value in between 1 and 0 over lerpedFactor (time)
            Color lerpedColor = Color.Lerp(_originalColor, _targetColor,
                lerpFactor);
            
            //the renderer material color equals the lerped color
            _objectRender.material.color = lerpedColor;

            //if the lerp factor (the time it takes) is less than 1f
            //than is fading is false
            //checks if the fade is complete
            if (lerpFactor >= 1f)
            {
                isFading = false;
            }
        }*/
    }

    public void FadeIn(float duration)
    {
        Color newColor = _originalColor;
        newColor.a = 1f;
        _objectRender.material.color = newColor;
        
        //set fade duration
        //this gets passed into the function
        //fadeDuration = duration;
        //Debug.Log("Fade Duration:" + fadeDuration);

        //reset the current time
        //currentTime = 0f;
        //Debug.Log("Current Time " + currentTime);

        //start fading
        //isFading = true;
        //Debug.Log("isFading " + isFading);
    }

    public void FadeOut(float duration)
    {

        Color newColor = _originalColor;
        newColor.a = 0f;
        _objectRender.material.color = newColor;
        
        //set fade duration
        //fadeDuration = duration;
        //Debug.Log("Fade Duration:" + fadeDuration);

        //reset current time
        //currentTime = 0f;
        //Debug.Log("Current Time " + currentTime);

        //stop fading
        //isFading = true;
        //Debug.Log("isFading " + isFading);
    }
}
