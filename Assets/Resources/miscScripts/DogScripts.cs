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
    float timeLeft;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();

        animator.SetBool("walk", true);
         rndom = new System.Random();
        timeLeft = 60;
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

            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
            timeLeft = 60;
            animator.SetTrigger("Yawn");

        }


    }

    void OnCollisionEnter(Collision col) {
        if (col.gameObject.CompareTag("PlayerHand"))
        {
            animator.SetBool("Wiggle", true);
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
