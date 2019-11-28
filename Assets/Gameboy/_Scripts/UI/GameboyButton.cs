using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Odi.Gameboy.UI {

    public class GameboyButton : Button {

        public event Action OnPress;
        public event Action OnRelease;
        public event Action OnClick;

        public override void OnPointerDown (UnityEngine.EventSystems.PointerEventData eventData) {

            base.OnPointerDown (eventData);
            if (OnPress != null)
                OnPress ();
        }

        public override void OnPointerUp (UnityEngine.EventSystems.PointerEventData eventData) {

            base.OnPointerUp (eventData);
            if (OnRelease != null)
                OnRelease ();
        }

        public override void OnPointerClick (UnityEngine.EventSystems.PointerEventData eventData) {

            base.OnPointerClick (eventData);
            if (OnClick != null)
                OnClick ();
        }

        public void ResetCallbacks () {

            OnPress = null;
            OnRelease = null;
            OnClick = null;
        }
    }
}