using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr.Obstacles
{
    public class ObstacleSpawner : MonoBehaviour
    {
        private float _xPosition = 13.0f;
        private float _yPosition;
        private float _yBoards = 5.0f;


        private void Start()
        {
            StartCoroutine(SpawnObstacle());
        }

        private IEnumerator SpawnObstacle()
        {
            while(true)
            {
                yield return new WaitForSeconds(1);
                GameObject obstacle = ObjectPoolObstacle.SharedInstance.GetPooledObject();
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
