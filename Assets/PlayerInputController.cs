using UnityEngine;
using OVRTouchSample;
using System.Collections;

public class PlayerInputController : MonoBehaviour
{
    public new Animator animation;

    // Use this for initialization
    OVRManager ovrManager;
    void Start()
    {
        animation = gameObject.GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {    // Press A
        if (Input.GetKeyDown(KeyCode.A))
        {
            //while () {
            animation.Play("Eating_Drinking2");
          
            //    animation["wagging"].layer = 1;
            //    animation.Play("wagging");
            //    animation["wagging"].weight = 0.4f;
            //}
            Debug.Log("A was pressed");
        }
        else if (Input.GetKeyDown(KeyCode.W))
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
        else if (Input.GetKeyDown(KeyCode.S))
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
        else if (Input.GetKeyDown(KeyCode.D))
        {
            //    // Right Trigger is held down
            //    while(  ) {

            //    }
            //}
            Debug.Log("RIGHT");
        }
    }
}
