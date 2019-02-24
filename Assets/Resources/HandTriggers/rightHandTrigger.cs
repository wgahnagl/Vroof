using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightHandTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider myTrigger)
    { 
        if (myTrigger.gameObject.tag.Equals("shibe"))
        {
            Debug.Log("patting the dog with right hand, reacting on tag!");
        }
    }
}
