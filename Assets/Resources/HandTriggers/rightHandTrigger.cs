using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightHandTrigger : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("right locked and loaded");
    }
    void OnTriggerEnter(Collider myTrigger)
    {
        Debug.Log("collidedRight, trigger");
    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("collidedRight, collision");
    }
}
