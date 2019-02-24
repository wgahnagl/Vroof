using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getButtonPress : MonoBehaviour
{
    OVRInput.Controller controller = OVRInput.Controller.None;

    // Start is called before the first frame update
    void Start()
    {
        if (OVRInput.IsControllerConnected(OVRInput.Controller.LTrackedRemote))
        {
            controller = OVRInput.Controller.LTrackedRemote;
        }
        else if (OVRInput.IsControllerConnected(OVRInput.Controller.RTrackedRemote))
        {
            controller = OVRInput.Controller.RTrackedRemote;
        }

    //   Vector2 touchpadPos = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad, controller);
    //   bool touchpadPressed = OVRInput.Get(OVRInput.Button.One, controller);
    //   bool backButtonPressed = OVRInput.Get(OVRInput.Button.Two, controller);
    //   bool triggerPressed = OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, controller);

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 touchpadPos = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad, controller);
        bool touchpadPressed = OVRInput.Get(OVRInput.Button.One, controller);
        bool backButtonPressed = OVRInput.Get(OVRInput.Button.Two, controller);
        bool triggerPressed = OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, controller);
    }
}
