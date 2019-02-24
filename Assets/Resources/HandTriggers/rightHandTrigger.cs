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
        if (myTrigger.gameObject.name.Equals("sheeb"))
        {
            Debug.Log("patting the dog with right hand, reacting on name!");
        }
        if (myTrigger.gameObject.tag.Equals("shibe"))
        {
            Debug.Log("patting the dog with right hand, reacting on tag!");
        }
    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("collidedRight, collision");
    }
}
