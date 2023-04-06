using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Evstr.GameScore
{
    public class LastScore : MonoBehaviour
    {
        private Score _score;
        private int _lastscore = 0;

        [SerializeField] private TMP_Text _lastScoreText;

        private void Awake()
        {
            _score = GetComponent<Score>();
            _lastscore = PlayerPrefs.GetInt("LastScore");
        }

        private void Start()
        {
           _lastScoreText.text = _lastscore.ToString();
        }

    }
}
