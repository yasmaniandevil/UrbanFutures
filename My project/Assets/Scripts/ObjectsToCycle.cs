using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsToCycle : MonoBehaviour
{
    private GameObject[] _objectsToCycle;

    private int currentIndex = 0;

    private int numObjects;
    
    // Start is called before the first frame update
    void Start()
    {
        
        _objectsToCycle = GameObject.FindGameObjectsWithTag("ObjectsToCycle");
        numObjects = _objectsToCycle.Length;

        for (int i = 1; 1 < numObjects; i++)
        {
            _objectsToCycle[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //Debug.Log("KeyPressed");
            _objectsToCycle[currentIndex].SetActive(false);
            //Debug.Log("current game obj" + currentIndex);
            currentIndex = (currentIndex + 1) % numObjects;
            //Debug.Log("current index: " + currentIndex);
            
            _objectsToCycle[currentIndex].SetActive(true);
            //Debug.Log("Switched to GameObject: " + currentIndex);
        }
        
       
    }
}
