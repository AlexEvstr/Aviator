using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Evstr.GameScore
{
    public class BestMenu : MonoBehaviour
    {
        [SerializeField] private TMP_Text _best;

        private int _bestscore;

        private void Start()
        {
            _bestscore = PlayerPrefs.GetInt("Best Score");
            _best.text = _bestscore.ToString();
        }
    }
}
