using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;


public class CameraSwitcher : MonoBehaviour
{
    public static List<CinemachineVirtualCamera> cameras = new List<CinemachineVirtualCamera>();

    public static CinemachineVirtualCamera ActiveCamera = null;

    public static bool IsActiveCamera(CinemachineVirtualCamera camera)
    {
        return camera == ActiveCamera;
    }

    public static void SwitchCamera(CinemachineVirtualCamera camera)
    {
        //set camera priority to 10
        camera.Priority = 10;
        //set camera for switch
        ActiveCamera = camera;

        foreach (CinemachineVirtualCamera c in cameras)
        {
            //set priorites to zero
            if (c != camera && c.Priority != 0)
            {
                c.Priority = 0;
            }
        }
    }

    public static void Register(CinemachineVirtualCamera camera)
    {
        cameras.Add(camera);
        Debug.Log("Camera registered: " + camera);
    }

    public static void Unregister(CinemachineVirtualCamera camera)
    {
        cameras.Remove(camera);
        Debug.Log("Camera unregistered: " + camera);
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
