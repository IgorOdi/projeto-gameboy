using Odi.Gameboy.Enums;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Odi.Gameboy.UI {

    public class DirectionalButton : Graphic, IPointerDownHandler, IPointerEnterHandler, IPointerUpHandler, IPointerExitHandler {

        public Image targetGraphic;
        private DirectionalPadController directionalPad;
        private (DirectionalAxis axis, int value) axisValue;

        public void SetPad (DirectionalPadController _directionalPad, (DirectionalAxis, int) _axisValue) {

            directionalPad = _directionalPad;
            axisValue = _axisValue;
        }

        public void OnPointerDown (PointerEventData eventData) {

            directionalPad.isPressingAnyButton = true;
            targetGraphic.color = Color.gray;
            SetPadValue ();
        }

        public void OnPointerEnter (PointerEventData eventData) {

            if (directionalPad.isPressingAnyButton) {

                targetGraphic.color = Color.gray;
                SetPadValue ();
            }
        }

        public void OnPointerUp (PointerEventData eventData) {

            directionalPad.isPressingAnyButton = false;
            targetGraphic.color = Color.white;
            ResetPadValue ();
        }

        public void OnPointerExit (PointerEventData eventData) {

            targetGraphic.color = Color.white;
            ResetPadValue ();
        }

        public void SetPadValue () {

            if (axisValue.axis.Equals (DirectionalAxis.HORIZONTAL)) {

                directionalPad.horizontalValue = axisValue.value;
            } else {

                directionalPad.verticalValue = axisValue.value;
            }
        }

        public void ResetPadValue () {

            directionalPad.horizontalValue = 0;
            directionalPad.verticalValue = 0;
        }

    }
}