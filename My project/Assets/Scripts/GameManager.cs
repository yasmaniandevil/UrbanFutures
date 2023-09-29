using System;
using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public static Vector3 spawnLocation;
    
    [FormerlySerializedAs("_player")] public CharacterController _playerController;
    public static GameObject _player;

    public Vector3 _playerPos;
    
    //list of 3D sprite GameObjects
    /*public static List<GameObject> sprites;
    //list of locations
    public List<Transform> locations;
    //the currently selected sprite
    private GameObject selectedSprite;
    //index to keep track of the currently selected sprite
    private int currentIndex = -1;*/

    // Start is called before the first frame update
    void Start()
    {
        /*//store gaameobjects w tag sprites into a spritearray
        GameObject[] spriteArray = GameObject.FindGameObjectsWithTag("sprites");
        //create a new list of these sprite arrays
        sprites = new List<GameObject>(spriteArray);
        //run function select next sprite
        SelectNextSprite();*/
        
        //
        
    }

    private void Awake()
    {
        //ResetPlayer();
    }

    /*private void SelectNextSprite()
    {
        //keep cycling thru the list
        currentIndex++;
        //if we reach end of the list loop back to beginning
        if (currentIndex >= sprites.Count)
        {
            //then you set index to 0
            currentIndex = 0;
        }

        //store the currently selected sprite
        selectedSprite = sprites[currentIndex];
    }

    public void MovePlayerToLocation()
    {
        //if selected sprite does not equal null
        if (selectedSprite != null)
        {
            //then move player location to target location
            ThirdPersonController.Instance.MoveToLocation(locations[currentIndex].position);
        }
    }

    public void OnSpriteClick(GameObject clickedSprite)
    {
        Debug.Log("sprite clicked" + clickedSprite.name);
        //check if the clicked sprite is the currently selected sprite
        if (selectedSprite == clickedSprite)
        {
            Debug.Log("Move to next location");
            //if it is select the next sprite and move the player to its location
            SelectNextSprite();
            MovePlayerToLocation();
        }
    }*/

    // Update is called once per frame
    
    //fixed update runs on a fixed timestamp

    private void Update()
    {
        /*if (_playerController.transform.position.y <= 35)
        {
            Debug.Log("Fell");
            //SceneManager.LoadScene(Application.loadedLevel);
            _player.transform.position = new Vector3(1065, 38, -35);
            Debug.Log("reset");

        }*/
        ResetPlayer();
        RestartScene();
    }

    void ResetPlayer()
    {
        
        if (_playerController.transform.position.y <= 35)
        {
            //Debug.Log("Fell");
            //SceneManager.LoadScene(Application.loadedLevel);
            //_player.transform.position = new Vector3(1065, 38, -35);
            //Debug.Log("reset");
            SceneManager.LoadScene(1);

        }
    }

    void RestartScene()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }
    //if player postion is < x than reset player postion to here
    
}