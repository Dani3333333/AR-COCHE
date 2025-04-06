using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harvester : MonoBehaviour
{
    public Transform car;
    public float speed = 1.5f;

    void Update()
    {
        Vector3 targetPos = car.position - new Vector3(0, 0, 2);
        transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime * speed);
    }
}

