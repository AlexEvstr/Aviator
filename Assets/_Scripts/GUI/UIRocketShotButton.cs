using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

namespace Evstr.GUI
{
    public class UIRocketShotButton : UIBaseButton
    {
        [SerializeField] private GameObject _rocketPrefab;
        [SerializeField] private GameObject _player;

        public override void OnClick()
        {
            var rocket = Instantiate(_rocketPrefab);
            rocket.transform.position = new Vector2(_player.transform.position.x, _player.transform.position.y - 0.24f);
        }
    }
}
