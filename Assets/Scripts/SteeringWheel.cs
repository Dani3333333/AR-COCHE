using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SteeringWheel : MonoBehaviour, IDragHandler, IEndDragHandler
{
    public CarController car;
    private float steerValue;
    public bool isActive = false; // <-- control si s’ha començat el joc
    public GameObject wheelGraphic;


    public void OnDrag(PointerEventData eventData)
    {
        if (!isActive) return;

        steerValue = eventData.delta.x / 100f;
        car.SetSteering(steerValue);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (!isActive) return;

        steerValue = 0f;
        car.SetSteering(0f);
    }

    // Aquest mètode el pots cridar des del botó
    public void ActivateSteering()
    {
        isActive = true;
        if (wheelGraphic != null)
            wheelGraphic.SetActive(true);

    }
}
