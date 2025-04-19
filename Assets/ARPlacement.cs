using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using System.Collections.Generic;

public class ARPlacement : MonoBehaviour
{
    public GameObject gameWorldPrefab; // Aquí poses el món del joc (carretera + cotxe)
    public ARRaycastManager raycastManager;
    private GameObject spawnedObject;

    void Update()
    {
        if (Input.touchCount == 0 || spawnedObject != null)
            return;

        Touch touch = Input.GetTouch(0);

        if (raycastManager.Raycast(touch.position, new List<ARRaycastHit>(), TrackableType.Planes))
        {
            Pose hitPose = new List<ARRaycastHit>()[0].pose;
            spawnedObject = Instantiate(gameWorldPrefab, hitPose.position, hitPose.rotation);
        }
    }
}
