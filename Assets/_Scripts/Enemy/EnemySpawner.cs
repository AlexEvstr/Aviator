using System.Collections;
using System.Collections.Generic;
using Evstr.Obstacles;
using UnityEngine;

namespace Evstr.Enemy
{
    public class EnemySpawner : MonoBehaviour
    {
        private float _xPosition = 13.0f;
        private float _yPosition;
        private float _yBoards = 5.0f;
        private float _randomTime;

        private void Start()
        {
            StartCoroutine(SpawnEnemy());
        }

        private IEnumerator SpawnEnemy()
        {
            while (true)
            {
                _randomTime = Random.Range(0.5f, 4.5f);
                yield return new WaitForSeconds(_randomTime);
                GameObject enemy = ObjectPoolEnemy.SharedInstance.GetPooledObject();
                _yPosition = Random.Range(-_yBoards, _yBoards);
                if (enemy != null)
                {
                    enemy.transform.position = new Vector2(_xPosition, _yPosition);
                    enemy.SetActive(true);
                }
            }
        }
    }
}
