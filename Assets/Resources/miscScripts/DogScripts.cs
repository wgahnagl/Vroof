using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DogScripts : MonoBehaviour
{
    Animator animator;
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();

        animator.SetBool("walk", true);
    }

    // Update is called once per frame
    void Update()
    {
        if (!agent.pathPending)
        {
            if (agent.remainingDistance <= agent.stoppingDistance)
            {
                if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f)
                {

                    animator.SetBool("walk", false);

                }
            }
                    else {
            animator.SetBool("walk", true);

        }
        }

    }

    
    void OnCollisionEnter(Collision col) {
        if (col.gameObject.CompareTag("PlayerHand"))
        {
            animator.SetBool("Wiggle", true);
            Debug.Log(animator.GetBool("Wiggle"));
           
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.CompareTag("PlayerHand"))
        {
            animator.SetBool("Wiggle", false);
        }
    }
}
