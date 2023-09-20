using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flatMovement : MonoBehaviour
{
    private Rigidbody2D rb2d;

    private Vector2 movement;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        movement = new Vector2(speed * inputX,
            speed * inputY);

    }

    private void FixedUpdate()
    {
        
        if (movement.x < 0f) {
            Debug.Log ("left");
        } else if (movement.x > 0f) {
            Debug.Log ("right");
        } 
		
        if (movement.y < 0f) {
            Debug.Log ("down");
        } else if (movement.y > 0f) {
            Debug.Log ("up");
        }
        rb2d.velocity = movement;
    }
}
