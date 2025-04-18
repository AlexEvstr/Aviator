using System.Collections;
using System.Collections.Generic;
using Evstr.Obstacles;
using UnityEngine;

namespace Evstr.Bonus
{
    public class BonusSpawner : MonoBehaviour
    {
        private float _xPosition = 13.0f;
        private float _yPosition;
        private float _yBoards = 5.0f;
        private float _randomTime;


        private void Start()
        {
            StartCoroutine(SpawnObstacle());
        }

        private IEnumerator SpawnObstacle()
        {
            while (true)
            {
                _randomTime = Random.Range(5f, 15f);
                yield return new WaitForSeconds(_randomTime);
                GameObject obstacle = ObjectPoolBonus.SharedInstance.GetPooledObject();
                _yPosition = Random.Range(-_yBoards, _yBoards);
                if (obstacle != null)
                {
                    obstacle.transform.position = new Vector2(_xPosition, _yPosition);
                    obstacle.SetActive(true);
                }
            }
        }
    }
}
