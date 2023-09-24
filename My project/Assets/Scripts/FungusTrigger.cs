using System;
using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class FungusTrigger : MonoBehaviour
{
    public Flowchart flowchart;
    //public BlockReference blocky;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            flowchart.ExecuteBlock("Petra");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
