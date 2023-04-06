using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Evstr.GameScore;

namespace Evstr.Bonus
{
    public class BonusDetector : MonoBehaviour
    {
        [SerializeField] private GameObject _plus50;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Bonus"))
            {
                collision.gameObject.SetActive(false);
                Score.score += 50;
                Instantiate(_plus50);
            }
        }
    }
}
