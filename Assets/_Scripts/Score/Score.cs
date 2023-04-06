using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Evstr.GameScore
{
    public class Score : MonoBehaviour
    {
        public static int score;

        [SerializeField] private TMP_Text _scoreText;

        private void Start()
        {
            StartCoroutine(Increase());
        }

        private IEnumerator Increase()
        {
            while (true)
            {
                yield return new WaitForSeconds(0.5f);
                score++;
            }
        }

        private void Update()
        {
            _scoreText.text = score.ToString();
        }

        private void OnDisable()
        {
            SaveScore();
        }

        public void SaveScore()
        {
            PlayerPrefs.SetInt("LastScore", score);
        }
    }
}
