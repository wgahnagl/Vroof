using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour
{
    public ConstantForce grav;
    // Start is called before the first frame update
    void Start()
    {
        grav = gameObject.AddComponent<ConstantForce>();
        grav.force = new Vector3(0.0f, -9.81f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Rigidbody>().useGravity = false;
    }
}
