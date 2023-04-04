using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Evstr.GUI
{
    public class UIMoveUpButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        [SerializeField] private GameObject _player;

        private float _speed = 5f;

        public bool buttonPressed;

        //public override void OnClick()
        //{
        //    if (_player.transform.position.y < 4.5f)
        //        _player.transform.Translate(Vector2.up * _speed * Time.deltaTime);
        //}



        public void OnPointerDown(PointerEventData eventData)
        {
            buttonPressed = true;
            StartCoroutine(MoveUp());
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            buttonPressed = false;

            StopCoroutine(MoveUp());
        }

        private IEnumerator MoveUp()
        {
           while (buttonPressed)
            {
                 _player.transform.Translate(Vector2.up * _speed * Time.deltaTime);
                yield return new WaitForSeconds(0);
            }
        }
    }
}
