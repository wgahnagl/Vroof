using UnityEngine;
using OVRTouchSample;
using System.Collections;

public class PlayerInputController : MonoBehaviour
{
    //public Animation animation;

    // Use this for initialization
    OVRManager ovrManager;
    void Start()
    {
        Debug.Log("haniiiii");
        //animation = gameObject.GetComponent<Animation>();
    }


    // Update is called once per frame
    void Update()
    {    // Press A



        OVRInput.Get(OVRInput.Button.One);
        if (OVRInput.Get(OVRInput.RawButton.A, OVRInput.Controller.RTouch))
        {
            //while () {
            //    animation.Play("feeding");
            //    animation["wagging"].layer = 1;
            //    animation.Play("wagging");
            //    animation["wagging"].weight = 0.4f;
            //}
            Debug.Log("A was pressed");
        }
        else if (OVRInput.Get(OVRInput.RawButton.X, OVRInput.Controller.LTouch))
        {
            // Press X
            //while ()
            //{
            //    animation.Play("feeding");
            //    animation["wagging"].layer = 1;
            //    animation.Play("wagging");
            //    animation["wagging"].weight = 0.4f;
            //}
            Debug.Log("X was Pressed");
        }
        else if (OVRInput.Get(OVRInput.RawButton.LIndexTrigger, OVRInput.Controller.LTouch))
        {
            //// Left Trigger is Held down
            //while(OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch)){
            //    animation.Play("ears");
            //    animation["wagging"].layer = 1;
            //    animation.Play("wagging");
            //    animation["wagging"].weight = 0.4f;
            //}
            Debug.Log("LEFT");
        }
        else if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger, OVRInput.Controller.RTouch))
        {
            //    // Right Trigger is held down
            //    while(  ) {

            //    }
            //}
            Debug.Log("RIGHT");
        }
    }
}
