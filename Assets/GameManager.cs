using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public CarController CarController;

    public void RestartGame()
    {
        Time.timeScale = 1f; // Per si has pausat el temps
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        CarController.ResetDistance();

    }
}
