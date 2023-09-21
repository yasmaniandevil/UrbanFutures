using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class CameraManager : MonoBehaviour
{


    //accesible in the editor but keeping it private
    [SerializeField] private Camera one;

    [SerializeField] private Camera two;

    [SerializeField] private GameObject player;
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
        if (one.isActiveAndEnabled)
        {
            one.gameObject.SetActive(false);
            player.gameObject.SetActive(true);
            Debug.Log("change to two");
        }
        else
        {
            one.gameObject.SetActive(true);
            player.gameObject.SetActive(false);
        }
        /*else  if (two.isActiveAndEnabled)
        {
            two.gameObject.SetActive(false);
            one.gameObject.SetActive(true);
            Debug.Log("change to one");
        }*/
    }
}
