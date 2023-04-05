using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr
{
    public class ObstacleDetector : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.gameObject.CompareTag("Player"))
            {
                Debug.Log("Obstacle - Game over");
            }
        }
    }
}
