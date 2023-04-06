using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Evstr.GameScore
{
    public class BestScore : MonoBehaviour
    {
        [SerializeField] private TMP_Text _bestScoreText;

        private int _bestScore;

        private void Awake()
        {
            _bestScore = PlayerPrefs.GetInt("Best Score");
        }

        private void Start()
        {
            _bestScoreText.text = _bestScore.ToString();
        }

        private void Update()
        {
            if (_bestScore < Score.score)
                _bestScore = Score.score;
            _bestScoreText.text = _bestScore.ToString();

        }

        private void OnDisable()
        {
            PlayerPrefs.SetInt("Best Score", _bestScore);
        }
    }
}
