using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftHandTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider myTrigger)
    {
        Debug.Log("Box went through!");
    }
}
