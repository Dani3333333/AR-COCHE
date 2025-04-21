using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStarter : MonoBehaviour
{
    public GameObject startPanel;
    public CarController CarController;
    public ObstacleSpawner ObstacleSpawner;

    public void StartGame()
    {
        CarController.enabled = true;
        ObstacleSpawner.enabled = true;
        startPanel.SetActive(false);
    }
}

