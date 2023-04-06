using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr.Enemy
{
    public class EnemyDetector : MonoBehaviour
    {
        [SerializeField] private GameObject _gameOverPanel;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.gameObject.CompareTag("Enemy"))
            {
                Time.timeScale = 0;
                _gameOverPanel.SetActive(true);
            }
        }
    }
}
