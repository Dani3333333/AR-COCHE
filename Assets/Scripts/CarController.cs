using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed = 2f;
    public float turnSpeed = 100f;
    public float steeringInput;

    void Update()
    {
        // Mou el cotxe endavant
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Gira segons el valor de steeringInput (de -1 a 1)
        transform.Rotate(Vector3.up, steeringInput * turnSpeed * Time.deltaTime);
    }

    public void SetSteering(float input)
    {
        steeringInput = Mathf.Clamp(input, -1f, 1f);
    }
}
