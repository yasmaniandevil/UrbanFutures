using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotation : MonoBehaviour
{

    public float rotationSpeed = 45f;

    public float xAngle, yAngle, zAngle;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        transform.Rotate(xAngle, yAngle, zAngle, Space.Self);
    }
}
