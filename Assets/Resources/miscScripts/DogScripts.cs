using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System;

public class DogScripts : MonoBehaviour
{
    Animator animator;
    NavMeshAgent agent;
    System.Random rndom;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();

        animator.SetBool("walk", true);
         rndom = new System.Random();
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

        int rand = rndom.Next(0, 1000);
        if (rand == 1) { 
            animator.SetTrigger("Yawn");
        }
    }


    void OnCollisionEnter(Collision col) {
        if (col.gameObject.CompareTag("PlayerHand"))
        {
            animator.SetBool("Wiggle", true);
            Debug.Log(animator.GetBool("Wiggle"));
            GameObject.Find("VfxBrightStars").GetComponent<ParticleSystem>().Play();
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.CompareTag("PlayerHand"))
        {
            animator.SetBool("Wiggle", false);
            GameObject.Find("VfxBrightStars").GetComponent<ParticleSystem>().Pause();

        }
    }

}
