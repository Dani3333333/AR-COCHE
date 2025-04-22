    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;

    public class CarCollisionHandler : MonoBehaviour
    {
        public GameObject gameOverPanel;
        public CarController carController;

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Obstacle"))
            {
                carController.enabled = false;
                gameOverPanel.SetActive(true);
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Obstacle") || other.CompareTag("OutOfBounds"))
            {
                carController.enabled = false;
                gameOverPanel.SetActive(true);
            }
        }

    }
