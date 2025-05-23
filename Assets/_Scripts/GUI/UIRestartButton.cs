using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Evstr.GameScore;

namespace Evstr.GUI
{
    public class UIRestartButton : UIBaseButton
    {
        public override void OnClick()
        {
            SceneManager.LoadScene(1);
            Time.timeScale = 1;
            Score.score = 0;
        }
    }
}
