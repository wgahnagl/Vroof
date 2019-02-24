using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightHandTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider myTrigger)
    { 
        if (myTrigger.gameObject.tag.Equals("shibe"))
        {
            GameObject.Find("sheeb").GetComponent<Animator>().SetBool("Wiggle", true);
        }
    }

    void OnTriggerExit(Collider myTrigger)
    {
        if (myTrigger.gameObject.tag.Equals("shibe"))
        {
            GameObject.Find("sheeb").GetComponent<Animator>().SetBool("Wiggle", false);
        }
    }
}
