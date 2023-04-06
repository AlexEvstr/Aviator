using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr.Player
{
    public class ObstacleDetector : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.gameObject.CompareTag("Obstacle"))
            {
                Debug.Log("Obstacle - Game over");
                Time.timeScale = 0;
            }
        }
    }
}
