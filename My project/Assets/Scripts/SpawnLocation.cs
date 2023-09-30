using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnLocation : MonoBehaviour

{
    private void Start()
    {
        //Debug.Log("Player's initial position: " + transform.position);
        // Set player's position using GameManager.spawnLocation
        //transform.position = GameManager.spawnLocation;
        //Debug.Log("Player's final position: " + transform.position);
    }

    public void SpawnPointFunctionStart()
    {
        GameManager.spawnLocation = new Vector3(1045.6f, 47.99f, -56.66f);
        //Debug.Log("spawn Location" + GameManager._player.transform.position);
        SceneManager.LoadScene(1);
    }
    public void SpawnPointFunctionRebecca()
    {
        //GameManager.spawnLocation = new Vector3(-23.156f, 7.188f, 17.662f);
        //Debug.Log("spawn Location" + GameManager.spawnLocation);
        //SceneManager.LoadScene(1);

        Vector3 newPos = new Vector3(-23.156f, 7.188f, 17.662f);
        //GameManager._player.GetComponent<ForPlayer>().SetPlayerPosition(new Vector3());
        SceneManager.LoadScene(1);
    }
    public void SpawnPointFunctionCherry()
    {
        GameManager.spawnLocation = new Vector3(1041.32f, 53.2565f, -25.508f);
        Debug.Log("spawn Location" + GameManager.spawnLocation);
        SceneManager.LoadScene(1);
    }

    public void SpawnPointFunctionVishu()
    {
        GameManager.spawnLocation = new Vector3(-4.7399f, 4.473f, 15.91f);
        SceneManager.LoadScene(1);
    }

    public void SpawnPointFunctionMarina()
    {
        GameManager.spawnLocation = new Vector3(1056.49f, 45.928f, -40.911f);
        SceneManager.LoadScene(1);
    }

    public void SpawnPointFunctionAdele()
    {
        GameManager.spawnLocation = new Vector3(1058.64f, 44.55f, -28.81f);
        SceneManager.LoadScene(1);
    }

    public void SpawnPointFunctionDami()
    {
        GameManager.spawnLocation = new Vector3(1024.34f,56.5350f, -47.219f);
        SceneManager.LoadScene(1);
    }

    public void SpawnPointFunctionRhianna()
    {
        GameManager.spawnLocation = new Vector3(-12.828f, -3.8173f, 26.1773f);
        SceneManager.LoadScene(1);
    }

    public void SpawnPointFunctionJacob()
    {
        GameManager.spawnLocation = new Vector3(-.85f, 0, 0);
        SceneManager.LoadScene(1);
    }

    public void SpawnPointFunctionPetra()
    {
        GameManager.spawnLocation = new Vector3(1032.02f, 44.6248f, -41.883f);
        SceneManager.LoadScene(1);
    }

    public void SpawnPointFunctionLiad()
    {
        GameManager.spawnLocation = new Vector3(1033.58f, 52.786f, -51.155f);
        SceneManager.LoadScene(1);
    }

    public void SpawnPointFunctionPeral()
    {
        GameManager.spawnLocation = new Vector3(1019.42f, 56.966f, -62.79f);
        SceneManager.LoadScene(1);
    }
    public void SpawnPointFunctionFernande()
    {
        GameManager.spawnLocation = new Vector3(1033.89f, 55.71f, -68.12f);
        SceneManager.LoadScene(1);
    }
    public void SpawnPointFunctionNat()
    {
        GameManager.spawnLocation = new Vector3(1041.87f, 55.6f, -48.164f);
        SceneManager.LoadScene(1);
    }

    public void SpawnPointFunctionCare()
    {
        GameManager.spawnLocation = new Vector3(0, 0, 0);
        SceneManager.LoadScene(1);
    }
    
    
}
