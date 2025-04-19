using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SteeringWheel : MonoBehaviour, IDragHandler, IEndDragHandler
{
    public CarController car;
    private float steerValue;

    public void OnDrag(PointerEventData eventData)
    {
        steerValue = eventData.delta.x / 100f;
        car.SetSteering(steerValue);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        steerValue = 0f;
        car.SetSteering(0f);
    }
}


