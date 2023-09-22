using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.Serialization;

public class CameraManager : MonoBehaviour
{
    //accessible in the editor but keeping it private
    //[SerializeField] private Camera CamOne;
    [SerializeField] private GameObject CamOne;
    [SerializeField] private GameObject playerCamOne;
    [SerializeField] private GameObject playerCamTwo;
    private GameObject currentCam;

    //private Camera currentCamera;
    // Start is called before the first frame update
    void Start()
    {
        //currentCam is camOne
        currentCam = CamOne;
    }

    // Update is called once per frame
    void Update()
    {
        //check if a camera is active here and update currentCam accordingly
        if (CamOne.activeSelf)
        {
            currentCam = CamOne;
        }
        //else if 
        else if (playerCamOne.activeSelf)
        {
            currentCam = playerCamOne;
        }
        else if (playerCamTwo.activeSelf)
        {
            currentCam = playerCamTwo;
        }
    }

    public void ChangeCamera()
    {
        //if cam one is current cam
        if (CamOne == currentCam)
        {
            Debug.Log("current cam assigned to currentCam Var:" + currentCam);
            //set game object inactive
            CamOne.gameObject.SetActive(false);
            //set cam one active
            playerCamOne.gameObject.SetActive(true);
            Debug.Log("playerCamOne is active");
        }
        else if(currentCam == playerCamOne)
        {
            Debug.Log("current cam assigned to currentCam Var:" + currentCam);
            CamOne.gameObject.SetActive(false);
            playerCamOne.gameObject.SetActive(false);
            playerCamTwo.gameObject.SetActive(true);
            Debug.Log("playerCamTwo is active");
        } 
        
    }
}
