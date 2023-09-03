using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    public CinemachineVirtualCamera cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
            if(CameraSwitcher.ActiveCamera != cam) CameraSwitcher.SwitchCamera(cam);
        }
    }
}
