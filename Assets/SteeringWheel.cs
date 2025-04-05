using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SteeringWheel : MonoBehaviour
{
    public RectTransform wheel;
    public CarController carController;
    private float wheelAngle;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                wheelAngle = Mathf.Clamp(wheelAngle + touch.deltaPosition.x, -30f, 30f);
                wheel.rotation = Quaternion.Euler(0, 0, -wheelAngle);
            }
        }
    }
}

