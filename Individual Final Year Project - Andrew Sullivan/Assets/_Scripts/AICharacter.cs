using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AICharacter : MonoBehaviour
{
    Animator aiAnim;

    NavMeshAgent aiNavMeshAgent;

    public float distanceFromTestTarget;
    public Transform testTarget;

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

        // Calculates the distance between the player and target, stores the value in a float variable.
        distanceFromTestTarget = Vector3.Distance(testTarget.position, transform.position);
        aiAnim.SetFloat("DistFromTarget", distanceFromTestTarget); // Sets the float value of the animator parameter "DistFromTarget" to whatever value is being stored in distanceFromTestTarget float variable.

        if (aiAnimStateInfo.IsName("ElizabethWalking")) // If it's current animator state is "Walking", it will set it's destination to the test target objects position.
        {
            aiNavMeshAgent.SetDestination(testTarget.position);
            aiNavMeshAgent.isStopped = false;
        }

        if (aiAnimStateInfo.IsName("ElizabethIdle") || aiAnimStateInfo.IsName("ElizabethDancing")) // If it's current animator state is "Idle" or "Dancing", it will not move.
        {
            aiNavMeshAgent.isStopped = true;
        }
    }
}
