using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SteeringWheel : MonoBehaviour, IDragHandler
{
    public CarController car;

    public void OnDrag(PointerEventData eventData)
    {
        float turn = Mathf.Clamp(eventData.delta.x / 100f, -1f, 1f);
        car.SetSteering(turn);
    }
}


