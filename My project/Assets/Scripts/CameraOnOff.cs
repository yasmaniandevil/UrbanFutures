using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOnOff : MonoBehaviour
{

    public GameObject Camera1;

    public GameObject Camera2;

    public GameObject Camera3;

    //create an array
    //public GameObject[] Cameras;

   //private int CurrentCam;
    
    // Start is called before the first frame update
    void Start()
    {
        //CurrentCam = 0;
        //setCam(CurrentCam);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*public void setCam(int idx)
    {
        for (int i = 0; i < Cameras.Length; i++)
        {
            if (i == idx)
            {
                Cameras[i].SetActive(true);
                
            }
            else
            {
                Cameras[i].SetActive(false);
            }
        }
    }

    public void toggleCam()
    {
        CurrentCam++;
        if (CurrentCam > Cameras.Length - 1) ;
            CurrentCam = 0;
        setCam(CurrentCam);
    }*/

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Trigger1")
        {
            Camera1.SetActive(false);
            Debug.Log("Disable: " + Camera1.name);
            Camera2.SetActive(true);
        }

        if (other.gameObject.tag == "Trigger2")
        {
            Camera2.SetActive(false);
            Camera3.SetActive(true);
        }
    }
    
    
}
