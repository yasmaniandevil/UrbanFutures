using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLocation : MonoBehaviour
{

    public static Vector3 spawnPoint;

    public float x, y, z;
    //have a spawn point
    //make a spawnPoint function
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnPointFunction()
    {
        spawnPoint = new Vector3(55, 69, 40);
    }
}
