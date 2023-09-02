using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOnOff : MonoBehaviour
{

    public GameObject Camera1;

    public GameObject Camera2;

    public GameObject Camera3;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Trigger1")
        {
            Camera1.SetActive(false);
            Debug.Log("Disable: " + Camera1.name);
            Camera2.SetActive(true);
        }
    }
}
