using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.Serialization;

public class CameraManager : MonoBehaviour
{


    //accesible in the editor but keeping it private
    [SerializeField] private Camera CamOne;
    //[SerializeField] private Camera CamTwo;
    [SerializeField] private GameObject playerCamOne;

    //private Camera currentCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeCamera()
    {
        if (CamOne.isActiveAndEnabled)
        {
            CamOne.gameObject.SetActive(false);
            playerCamOne.gameObject.SetActive(true);
            Debug.Log("change to two");
        }
        else
        {
            CamOne.gameObject.SetActive(true);
            playerCamOne.gameObject.SetActive(false);
        } 
        {
            
        }
        /*else  if (two.isActiveAndEnabled)
        {
            two.gameObject.SetActive(false);
            one.gameObject.SetActive(true);
            Debug.Log("change to one");
        }*/


        
    }
}
