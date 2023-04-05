using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.Pool;
using Evstr.Rocket;

namespace Evstr.GUI
{
    public class UIRocketShotButton : UIBaseButton
    {
        [SerializeField] private GameObject _player;

        public override void OnClick()
        {
            GameObject rocket = ObjectPoolRocket.SharedInstance.GetPooledObject();
            if (rocket != null)
            {
                rocket.transform.position = new Vector2(_player.transform.position.x, _player.transform.position.y - 0.24f);
                rocket.SetActive(true);
            }
        }
    }
}
