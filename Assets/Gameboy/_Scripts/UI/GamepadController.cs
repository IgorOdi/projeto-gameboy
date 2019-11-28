using UnityEngine;

namespace Odi.Gameboy.UI {

    public class GamepadController : MonoBehaviour {

        [Header ("Visuals"), SerializeField]
        private RectTransform canvas;
        [SerializeField]
        private RectTransform background;

        [Header ("Buttons")]
        public GameboyButton aButton;
        public GameboyButton bButton;

        [Header ("Directionals"), SerializeField]
        private DirectionalPadController directionalPad;

        private const float BUTTONS_SCREEN_PERCENTAGE = 0.375f;

        void Start () => Init ();

        public void Init () {

            background.offsetMax = new Vector2 (background.offsetMax.x, canvas.rect.height * BUTTONS_SCREEN_PERCENTAGE);
            directionalPad.ConfigurePad ();
        }

        public Vector2 GetDirectionalAxis () {

            return new Vector2 (directionalPad.horizontalValue, directionalPad.verticalValue);
        }
    }
}