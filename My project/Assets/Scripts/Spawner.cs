using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player.transform.position = GameManager.spawnLocation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
