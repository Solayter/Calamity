using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class MoveToTarget : MonoBehaviour
{

    public Transform goal;
    NavMeshAgent agent;
    //Animator playerAnimator;
    Rigidbody rb;

    public float upJumpSpeed = 5;
    public float forwardJumpSpeed = 1;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updatePosition = false;
        agent.updateRotation = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        agent.destination = goal.transform.position;

        Vector3 worldDeltaPosition = agent.nextPosition - transform.position;

        float turnSpeed = Vector3.Dot(Vector3.up, Vector3.Cross(transform.forward, worldDeltaPosition));
        SetTurnSpeed(turnSpeed);

        float forwardSpeed = Vector3.Dot(transform.forward, worldDeltaPosition);
        SetForwardSpeed(forwardSpeed);

        if (agent.isOnOffMeshLink)
        {
            Jump();
            agent.CompleteOffMeshLink();
        }
        //playerAnimator.applyRootMotion = Grounded();
        //playerAnimator.SetBool("grounded", Grounded());
    }
    void Awake()
    {
        //playerAnimator = GetComponent<Animator>();
        //playerAnimator.applyRootMotion = true;
        rb = GetComponent<Rigidbody>();
    }
 public bool Grounded()
    {
        return Mathf.Abs(Vector3.Dot(rb.velocity, Vector3.up)) < 0.01;
    }

    public void Jump()
    {
        if (Grounded())
        {
            //playerAnimator.SetTrigger("jump");
            rb.velocity += Vector3.up * upJumpSpeed + transform.forward * forwardJumpSpeed;
        }
    }

    public void Crouch()
    {
        //playerAnimator.SetTrigger("crouch");
    }

    public void SetTurnSpeed(float speed)
    {
        //playerAnimator.SetFloat("turnSpeed", speed);
    }

    public void SetForwardSpeed(float speed)
    {
        //playerAnimator.SetFloat("forwardSpeed", speed);
    }
}

