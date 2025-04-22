using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CarController : MonoBehaviour
{
    public float speed = 2f;
    public float turnSpeed = 100f;
    public float steeringInput;

    public TMP_Text distanceText; // TextMeshPro en lloc de Text
    private Vector3 startPosition;
    private float distanceTravelled;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // Mou el cotxe endavant
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Gira segons el valor de steeringInput
        transform.Rotate(Vector3.up, steeringInput * turnSpeed * Time.deltaTime);

        // Calcula la distància
        distanceTravelled = Vector3.Distance(startPosition, transform.position);
        distanceText.text = $"{Mathf.FloorToInt(distanceTravelled)} m";
    }

    public void SetSteering(float input)
    {
        steeringInput = Mathf.Clamp(input, -1f, 1f);
    }

    public void ResetDistance()
    {
        startPosition = transform.position;
        distanceTravelled = 0f;
    }
}
