using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnLocation : MonoBehaviour

{

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
    public void SpawnPointFunctionStart()
    {
        GameManager.spawnLocation = new Vector3(-22.15f, 7.72f, -24.7f);
        Debug.Log("spawn Location" + GameManager.spawnLocation);
        //SceneManager.LoadScene(0);
    }
    public void SpawnPointFunctionRebecca()
    {
        GameManager.spawnLocation = new Vector3(1025.33f, 55.269f, -33.985f);
        Debug.Log("spawn Location" + GameManager.spawnLocation);
        //SceneManager.LoadScene(0);
    }
    public void SpawnPointFunctionCherry()
    {
        GameManager.spawnLocation = new Vector3(1041.515f, 53.012f, -26.04f);
        Debug.Log("spawn Location" + GameManager.spawnLocation);
        SceneManager.LoadScene(0);
    }

    public void SpawnPointFunctionVishu()
    {
        GameManager.spawnLocation = new Vector3(50, 30, 20);
        SceneManager.LoadScene(0);
    }

    public void SpawnPointFunctionMarina()
    {
        GameManager.spawnLocation = new Vector3(50, 30, 20);
        SceneManager.LoadScene(0);
    }

    public void SpawnPointFunctionAdele()
    {
        GameManager.spawnLocation = new Vector3(50, 30, 20);
        SceneManager.LoadScene(0);
    }

    public void SpawnPointFunctionDami()
    {
        GameManager.spawnLocation = new Vector3(50, 30, 20);
        SceneManager.LoadScene(0);
    }

    public void SpawnPointFunctionRhianna()
    {
        GameManager.spawnLocation = new Vector3(50, 30, 20);
        SceneManager.LoadScene(0);
    }

    public void SpawnPointFunctionJacob()
    {
        GameManager.spawnLocation = new Vector3(50, 30, 20);
        SceneManager.LoadScene(0);
    }

    public void SpawnPointFunctionPetra()
    {
        GameManager.spawnLocation = new Vector3(50, 30, 20);
        SceneManager.LoadScene(0);
    }

    public void SpawnPointFunctionLiad()
    {
        GameManager.spawnLocation = new Vector3(50, 30, 20);
        SceneManager.LoadScene(0);
    }

    public void SpawnPointFunctionPeral()
    {
        GameManager.spawnLocation = new Vector3(50, 30, 20);
        SceneManager.LoadScene(0);
    }
    public void SpawnPointFunctionFernande()
    {
        GameManager.spawnLocation = new Vector3(50, 30, 20);
        SceneManager.LoadScene(0);
    }
    public void SpawnPointFunctionNat()
    {
        GameManager.spawnLocation = new Vector3(50, 30, 20);
        SceneManager.LoadScene(0);
    }
    
    
}
