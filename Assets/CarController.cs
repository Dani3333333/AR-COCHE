using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed = 5f;
    public float turnSpeed = 2f;
    private float horizontalInput;

    void Update()
    {
        // Control del volant
        horizontalInput = Input.acceleration.x; // Acceleròmetre (pot ser reemplaçat per touch input)
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.Rotate(Vector3.up, horizontalInput * turnSpeed);
    }
}

