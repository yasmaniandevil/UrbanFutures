using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public static movement Instance;

    private Rigidbody2D rb;

    public float forceAmount = 100;

    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    } 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //go forward
            rb.AddForce(Vector2.up * forceAmount);
            Debug.Log("w pressed");
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            //go backward
            rb.AddForce(Vector2.down * forceAmount);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            //go left
            rb.AddForce(Vector2.left * forceAmount);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            //go right
            rb.AddForce(Vector2.right * forceAmount);
        }

        rb.velocity *= 0.9f;
    }
}
