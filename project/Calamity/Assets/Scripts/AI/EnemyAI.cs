using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyAI : MonoBehaviour {

    private NavMeshAgent agent;
    private GameObject player;
    public Animator anim;
    public AudioClip attack;
    private AudioSource aud;
    private SearchingPlayer srch;
    public bool agressive = true;
    private bool ready = false;
    private bool attacked = false;
   
    void Start()
    {
        srch = GetComponentInChildren<SearchingPlayer>();
        agent = GetComponent<NavMeshAgent>();
        aud = GetComponent<AudioSource>();
        //anim.applyRootMotion = true;
    }

    void FixedUpdate()
    {
        //int a = Animator.StringToHash("Base Layer.Walk");
        if (agressive)
        {
            if (srch.player == null)
            {
                agent.isStopped = true;
                anim.SetTrigger("Idle");
            }
            else if (ready == false)
            {
                anim.SetTrigger("Walk");
                if (anim.GetCurrentAnimatorStateInfo(0).fullPathHash == Animator.StringToHash("Base Layer.Walk"))
                {
                    agent.isStopped = false;
                    agent.SetDestination(srch.player.transform.position);
                }
            }
            else
            {
                //agent.isStopped = true;
                anim.SetTrigger("Attack");
                
            }
        }
        else
        {
            agent.isStopped = true;
            anim.SetTrigger("Idle");
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ready = true;
            if (anim.GetCurrentAnimatorStateInfo(0).fullPathHash == Animator.StringToHash("Base Layer.Attack"))
            {
                if (!aud.isPlaying)
                {
                    aud.PlayOneShot(attack);
                    srch.player.GetComponent<PersonController>().healthPointsValue -= (20 - srch.player.GetComponent<PersonController>().armor);
                }
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ready = false;
        }
    }
}
