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

        if (myTrigger.gameObject.name.Equals("sheeb"))
        {
            Debug.Log("patting the dog with left hand, reacting on name!");
        }
        if (myTrigger.gameObject.tag.Equals("shibe"))
        {
            Debug.Log("patting the dog with left hand, reacting on tag!");
        }
        Debug.Log("collidedLeft, trigger");
    }
}
