using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        // move the vehicle   
        transform.Translate(Vector3.forward * Time.deltaTime * 20);
    }
}
