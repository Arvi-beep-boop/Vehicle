using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 15.0f;
    private float turnSpeed = 40.0f;
    private float horizontalInput;
    private float verticalInput;
    void Start()
    {
        
    }

    void Update()
    {
        // Player Input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Moves the vehicle forward based on vertical input  
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        // Rotates the vehicle based on horizontal input
        transform.Rotate(Vector3.up, horizontalInput *turnSpeed * Time.deltaTime);
    }
}
