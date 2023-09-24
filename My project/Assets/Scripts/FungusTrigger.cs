using System;
using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class FungusTrigger : MonoBehaviour
{
    public Flowchart flowchart;
    //public BlockReference blocky;
    public string blockName;
    private void OnTriggerEnter(Collider other)
    {
        /*if (other.CompareTag("Player"))
        {
            flowchart.ExecuteBlock("Petra");
        }*/
        
        if (flowchart == null)
        {
            Debug.Log("Flowchart refrence is not set");
        }

        Block block = flowchart.FindBlock(blockName);
        if (block != null)
        {
            flowchart.ExecuteBlock(block);
            Debug.Log("blocked fired: " + block);
        }
        else
        {
            Debug.Log("Block not found: " + blockName);
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
