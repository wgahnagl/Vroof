using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftHandTrigger : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("hey what");
    }
    void OnTriggerEnter(Collider myTrigger)
    {
        Debug.Log("Box went through!");
    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("aaa");
    }
}
