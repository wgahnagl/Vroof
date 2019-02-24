using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour
{
    public new Animation animation;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Press A
        if (OVRInput.Get(OVRInput.Button.One, OVRInput.Controller.RTouch)) {
            while () {
                animation.Play("feeding");
                animation["wagging"].layer = 1;
                animation.Play("wagging");
                animation["wagging"].weight = 0.4f;
            }
        } else if (OVRInput.Get(OVRInput.Button.Three, OVRInput.Controller.LTouch)) {
            // Press X
            while ()
            {
                animation.Play("feeding");
                animation["wagging"].layer = 1;
                animation.Play("wagging");
                animation["wagging"].weight = 0.4f;
            }
        } else if (OVRInput.Get(Axis1D.PrimaryIndexTrigger)) {
            // Left Trigger is Held down
            while(OVRInput.Get(Axis1D.PrimaryIndexTrigger) {
                animation.Play("ears-down");
                animation["wagging"].layer = 1;
                animation.Play("wagging");
                animation["wagging"].weight = 0.4f;
                if () {

                }
            }
        } else if(OVRInput.Get(Axis1D.SecondaryIndexTrigger)){
            while(  ) {
                
            }
        }
    }
}
