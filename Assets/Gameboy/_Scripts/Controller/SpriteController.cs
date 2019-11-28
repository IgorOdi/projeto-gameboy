using Odi.Gameboy.UI;
using UnityEngine;

public class SpriteController : MonoBehaviour {

    public GamepadController padController;

    void Update () {

        transform.Translate (padController.GetDirectionalAxis () * Time.deltaTime * 4);
    }
}