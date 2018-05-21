using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class MoveToTarget : MonoBehaviour
{
    private NavMeshAgent agent;
    private GameObject player;
    public Transform target;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void FixedUpdate()
    {
        agent.SetDestination(target.position);
    }
}
