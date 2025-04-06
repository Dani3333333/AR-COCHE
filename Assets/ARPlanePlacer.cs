using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARPlanePlacer : MonoBehaviour
{
    public GameObject roadPrefab;
    private GameObject spawnedRoad;
    public ARRaycastManager raycastManager;
    static List<ARRaycastHit> hits = new List<ARRaycastHit>();

    void Update()
    {
        if (spawnedRoad == null && Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (raycastManager.Raycast(touch.position, hits, TrackableType.PlaneWithinPolygon))
            {
                Pose pose = hits[0].pose;
                spawnedRoad = Instantiate(roadPrefab, pose.position, pose.rotation);
            }
        }
    }
}

