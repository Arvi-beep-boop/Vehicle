using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public string inputID;
    public KeyCode cameraToggleKey;
    public Camera mainCamera;
    public Camera hoodCamera;
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
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        verticalInput = Input.GetAxis("Vertical" + inputID);

        // Moves the vehicle forward based on vertical input  
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        // Rotates the vehicle based on horizontal input
        transform.Rotate(Vector3.up, horizontalInput *turnSpeed * Time.deltaTime);

        if(Input.GetKeyDown(cameraToggleKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }
}
