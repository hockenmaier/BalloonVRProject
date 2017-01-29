using UnityEngine;
using System.Collections;

public class WandController : MonoBehaviour {

    private Valve.VR.EVRButtonId gripButton = Valve.VR.EVRButtonId.k_EButton_Grip;
    private Valve.VR.EVRButtonId triggerButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;
    private Valve.VR.EVRButtonId trackPad = Valve.VR.EVRButtonId.k_EButton_SteamVR_Touchpad;
    private Valve.VR.EVRButtonId trackPadAxis0 = Valve.VR.EVRButtonId.k_EButton_Axis0;
    private Valve.VR.EVRButtonId trackPadAxis1 = Valve.VR.EVRButtonId.k_EButton_Axis1;



    private SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input((int)trackedObj.index); } }
    private SteamVR_TrackedObject trackedObj;
	// Use this for initialization
	void Start () {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (controller == null)
        {
            Debug.Log("Controller not initialized");
            return;
        }

        if (controller.GetPressDown(gripButton))
        {
            Debug.Log("Grip Button Pressed");
        }
        if (controller.GetPressUp(gripButton))
        {
            Debug.Log("Grip Button Unpressed");
        }
        if (controller.GetPressDown(triggerButton))
        {
            Debug.Log("Trigger Button Pressed");
        }
        if (controller.GetPressUp(triggerButton))
        {
            Debug.Log("Trigger Button Unpressed");
        }
        if (controller.GetPress(trackPad))
        {
            Debug.Log("Trackpad pressed at " + controller.GetAxis(trackPadAxis0));
            Debug.Log(UnityEngine.Input.GetJoystickNames());
            
        }
    }
}
