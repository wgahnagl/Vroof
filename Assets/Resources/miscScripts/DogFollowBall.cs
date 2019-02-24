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
        time = 10;
    }

    void OnCollisionExit(Collision collision) {
        if (collision.gameObject.name.Equals("floor")) {
            GameObject.Find("sheeb").GetComponent<NavMeshAgent>().SetDestination(minorFocus.position);
        }
        Debug.Log("exit");
    }


    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (time < 0)
        {
            time = 15;
            GameObject.Find("sheeb").GetComponent<NavMeshAgent>().SetDestination(mainFocus.position);
            Debug.Log("time's up");
        }
    }
}
