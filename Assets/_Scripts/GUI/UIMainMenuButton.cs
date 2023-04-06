using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Evstr.GUI
{
    public class UIMainMenuButton : UIBaseButton
    {
        public override void OnClick()
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1;
        }
    }
}
