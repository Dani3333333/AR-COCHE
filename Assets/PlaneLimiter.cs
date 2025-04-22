using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneLimiter : MonoBehaviour
{
    public Vector2 planeSize = new Vector2(1, 1); // Ample i llarg del pla
    public Vector3 planeCenter;

    void Update()
    {
        Vector3 localPos = transform.position - planeCenter;

        if (Mathf.Abs(localPos.x) > planeSize.x / 2 || Mathf.Abs(localPos.z) > planeSize.y / 2)
        {
            transform.position -= transform.forward * Time.deltaTime;
        }
    }
}

