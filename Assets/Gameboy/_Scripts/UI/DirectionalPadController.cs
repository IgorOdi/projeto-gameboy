using Odi.Gameboy.Enums;
using UnityEngine;

namespace Odi.Gameboy.UI {

    [System.Serializable]
    public class DirectionalPadController {

        [HideInInspector]
        public int horizontalValue;
        [HideInInspector]
        public int verticalValue;

        [HideInInspector]
        public bool isPressingAnyButton;

        [SerializeField]
        private DirectionalButton up;
        [SerializeField]
        private DirectionalButton down;
        [SerializeField]
        private DirectionalButton left;
        [SerializeField]
        private DirectionalButton right;

        public void ConfigurePad () {

            up.SetPad (this, (DirectionalAxis.VERTICAL, 1));
            down.SetPad (this, (DirectionalAxis.VERTICAL, -1));
            left.SetPad (this, (DirectionalAxis.HORIZONTAL, -1));
            right.SetPad (this, (DirectionalAxis.HORIZONTAL, 1));
        }
    }
}