using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

namespace Evstr.Rocket
{
    public class RockerMovement : MonoBehaviour
    {
        private float _speed = 8.0f;

        private void Update()
        {
            transform.Translate(Vector2.right * _speed * Time.deltaTime);
            if (transform.position.x > 13.0f)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
