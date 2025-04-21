using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstaclePrefabs; // Prefabs dels obstacles
    public Transform carTransform;       // Per saber on est� el cotxe (per spawnar al davant)
    public float spawnInterval = 0.5f;     // Cada quant apareix un obstacle
    public float spawnDistance = 30f;    // A quina dist�ncia davant del cotxe apareix
    public float laneOffset = 1.5f;      // Posici� lateral dels carrils

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnObstacle();
            timer = 0f;
        }
    }

    void SpawnObstacle()
    {
        // Tria aleat�riament un carril: -1 (esquerra), 0 (centre), 1 (dreta)
        int lane = Random.Range(-1, 2);
        Vector3 spawnPos = new Vector3(
            lane * laneOffset,
            carTransform.position.y,
            carTransform.position.z + spawnDistance
        );

        // Tria un prefab aleatori i instancia�l
        int prefabIndex = Random.Range(0, obstaclePrefabs.Length);
        GameObject obstacle = Instantiate(obstaclePrefabs[prefabIndex], spawnPos, Quaternion.identity, transform);

        // Rota perqu� la part llarga estigui mirant cap al cotxe (horitzontal)
        obstacle.transform.rotation = Quaternion.Euler(0, 90, 0);
    }
}
