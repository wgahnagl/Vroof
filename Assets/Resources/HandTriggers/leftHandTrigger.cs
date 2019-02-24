using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftHandTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider myTrigger)
    {
        if (myTrigger.gameObject.tag.Equals("shibe"))
        {
            Debug.Log("patting the dog with left hand, reacting on tag!");
        }
    }
}
