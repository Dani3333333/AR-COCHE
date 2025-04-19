using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstaclePrefabs; // Llista de prefabs d'obstacles
    public Transform roadStartPoint;     // On comença la carretera
    public int numberOfSections = 20;    // Quants segments té la carretera
    public float sectionSpacing = 5f;    // Distància entre cada secció
    public float laneOffset = 1.5f;      // Posició lateral dels carrils

    void Start()
    {
        SpawnObstacles();
    }

    void SpawnObstacles()
    {
        for (int i = 1; i <= numberOfSections; i++)
        {
            float zPos = roadStartPoint.position.z + i * sectionSpacing;

            // Aleatòriament escollim 2 carrils per posar-hi obstacles
            int[] lanes = { -1, 0, 1 }; // -1 = esquerra, 0 = centre, 1 = dreta
            ShuffleArray(lanes);

            // Posem obstacles als 2 primers carrils
            for (int j = 0; j < 2; j++)
            {
                Vector3 spawnPos = new Vector3(
                    lanes[j] * laneOffset,
                    roadStartPoint.position.y,
                    zPos
                );

                int prefabIndex = Random.Range(0, obstaclePrefabs.Length);
                Instantiate(obstaclePrefabs[prefabIndex], spawnPos, Quaternion.identity, transform);
            }
        }
    }

    void ShuffleArray(int[] array)
    {
        for (int i = array.Length - 1; i > 0; i--)
        {
            int rnd = Random.Range(0, i + 1);
            int temp = array[i];
            array[i] = array[rnd];
            array[rnd] = temp;
        }
    }
}
