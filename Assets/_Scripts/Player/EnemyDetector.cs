using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr.Enemy
{
    public class EnemyDetector : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.gameObject.CompareTag("Enemy"))
            {
                Debug.Log("Enemy - Game Over");
                Time.timeScale = 0;
            }
        }
    }
}
