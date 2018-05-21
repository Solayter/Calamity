using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BirdAI : MonoBehaviour {

    private NavMeshAgent agent;
    public List<GameObject> points = new List<GameObject>();
    public Animator anim;
    private System.Random rand = new System.Random();
    private GameObject target;
    private GameObject targetNew;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        ChooseNextPoint();
    }
    
    void FixedUpdate ()
    {
        agent.SetDestination(target.transform.position);
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Point"))
        {
            ChooseNextPoint();
        }
    }
    private void ChooseNextPoint()
    {
        targetNew = points[rand.Next(0, points.Count-1)];
        if (targetNew.Equals(target))
            ChooseNextPoint();
        else target = targetNew;
    }
    
}
