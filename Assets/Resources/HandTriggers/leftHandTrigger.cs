using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftHandTrigger : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("left locked and loaded");
    }
    void OnTriggerEnter(Collider myTrigger)
    {
        Debug.Log("collidedLeft, trigger");
    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("collidedLeft, collision");
    }
}
