using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGoingVehicleController : MonoBehaviour
{
    public float speed = 3.0f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
