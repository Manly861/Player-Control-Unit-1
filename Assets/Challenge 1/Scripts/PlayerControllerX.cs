﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 0.5f;
    public float rotationSpeed = 50.0f;
    public float verticalInput;
    public float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");


        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.up, rotationSpeed * horizontalInput* Time.deltaTime);
    }
}
