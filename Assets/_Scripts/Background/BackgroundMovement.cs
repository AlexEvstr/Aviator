using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr.Background
{
    public class BackgroundMovement : MonoBehaviour
    {
        private float _speed = 5.0f;

        private void Update()
        {
            transform.Translate(Vector2.left * _speed * Time.deltaTime);
        }
    }
}
