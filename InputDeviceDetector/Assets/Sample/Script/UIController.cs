
using UnityEngine;
using UnityEngine.UI;

namespace InputDeviceDetection
{    
    public class UIController : MonoBehaviour
    {
        [SerializeField] Image iconMouse;
        [SerializeField] Image iconKeyboard;
        [SerializeField] Image iconGamepad;
        [SerializeField] Text deviceName;

        void Start()
        {
            InputDeviceDetector.OnSwitchToMouse.AddListener(SwitchToMouse);
            InputDeviceDetector.OnSwitchToKeyboard.AddListener(SwitchToKeyboard);
            InputDeviceDetector.OnSwitchToGamepad.AddListener(SwitchToGamepad);
        }

        void SwitchToMouse()
        {
            InputDeviceDetector.ShowCursor();
            iconMouse.enabled = true;
            iconKeyboard.enabled = false;
            iconGamepad.enabled = false;
            deviceName.text = "<color=blue>Mouse</color>";
        }

        void SwitchToKeyboard()
        {
            InputDeviceDetector.HideCursor();
            iconKeyboard.enabled = true;
            iconMouse.enabled = false;
            iconGamepad.enabled = false;
            deviceName.text = "<color=red>Keyboard</color>";
        }

        void SwitchToGamepad()
        {
            InputDeviceDetector.HideCursor();
            iconGamepad.enabled = true;
            iconKeyboard.enabled = false;
            iconMouse.enabled = false;
            deviceName.text = "<color=green>Gamepad</color>";
        }
    }
}