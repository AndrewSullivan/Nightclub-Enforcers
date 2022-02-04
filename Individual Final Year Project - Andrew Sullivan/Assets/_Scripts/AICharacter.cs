using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AICharacter : MonoBehaviour
{
    Animator aiAnim;

    NavMeshAgent aiNavMeshAgent;

    public float distanceFromDanceFloor;
    public float distanceFromBar;
    public Transform danceFloor;
    public Transform bar;

    // Start is called before the first frame update
    void Start()
    {
        aiAnim = GetComponent<Animator>();
        aiNavMeshAgent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        // Get's current animation state of character.
        AnimatorStateInfo aiAnimStateInfo = aiAnim.GetCurrentAnimatorStateInfo(0);

        // Calculates the distance between the player and dance floor, stores the value in a float variable.
        distanceFromDanceFloor = Vector3.Distance(danceFloor.position, transform.position);
        aiAnim.SetFloat("DistFromDanceFloor", distanceFromDanceFloor); // Sets the float value of the animator parameter "DistFromDanceFloor" to whatever value is being stored in distanceFromDanceFloor float variable.

        // Calculates the distance between the player and bar, stores the value in a float variable.
        distanceFromBar = Vector3.Distance(bar.position, transform.position);
        aiAnim.SetFloat("DistFromBar", distanceFromBar); // Sets the float value of the animator parameter "DistFromBar" to whatever value is being stored in distanceFromBar float variable.

        if (aiAnimStateInfo.IsName("ElizabethWalking")) // If it's current animator state is "Walking", it will set it's destination to the test target objects position.
        {
            aiNavMeshAgent.SetDestination(danceFloor.position);
            aiNavMeshAgent.isStopped = false;
        }

        if (aiAnimStateInfo.IsName("ElizabethWalking2")) // If it's current animator state is "Walking", it will set it's destination to the test target objects position.
        {
            aiNavMeshAgent.SetDestination(bar.position);
            aiNavMeshAgent.isStopped = false;
        }

        if (aiAnimStateInfo.IsName("ElizabethIdle") || aiAnimStateInfo.IsName("ElizabethDancing")) // If it's current animator state is "Idle" or "Dancing", it will not move.
        {
            aiNavMeshAgent.isStopped = true;
        }
    }
}
