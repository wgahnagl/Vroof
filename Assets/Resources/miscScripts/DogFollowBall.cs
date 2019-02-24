using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DogFollowBall : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform mainFocus;
    public Transform minorFocus;


    float time;
    // Start is called before the first frame update
    void Start()
    {
        time = 2;
    }

    void OnCollisionExit(Collision collision) {
        if (collision.gameObject.name.Equals("floor")) {
            GameObject.Find("sheeb").GetComponent<NavMeshAgent>().SetDestination(minorFocus.position);
        }
    }


    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (time < 0)
        {
            time = 60;
            GameObject.Find("sheeb").GetComponent<NavMeshAgent>().SetDestination(mainFocus.position);
        }
    }
}
