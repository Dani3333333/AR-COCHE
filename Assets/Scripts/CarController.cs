using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float forwardSpeed = 2f;
    public float turnSpeed = 50f;
    public float turnInput = 0f;

    void Update()
    {
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up, turnInput * turnSpeed * Time.deltaTime);
    }

    public void SetSteering(float input)
    {
        turnInput = input;
    }
}


