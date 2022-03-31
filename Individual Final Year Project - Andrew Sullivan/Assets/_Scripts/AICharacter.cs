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
    public GameObject danceFloor;
    //private GameObject bar;

    public bool isFighting;

    // Start is called before the first frame update
    void Start()
    {
        aiAnim = GetComponent<Animator>();
        aiNavMeshAgent = GetComponent<NavMeshAgent>();

        isFighting = true;

        danceFloor = GameObject.Find("Dance Floor Model");


       // bar = GameObject.FindGameObjectWithTag("Bar");

        //Transform barPosition = bar.GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        // Get's current animation state of character.
        AnimatorStateInfo aiAnimStateInfo = aiAnim.GetCurrentAnimatorStateInfo(0);

        /*// Calculates the distance between the player and dance floor, stores the value in a float variable.
        distanceFromDanceFloor = Vector3.Distance(danceFloor.transform.position, transform.position);
        aiAnim.SetFloat("DistFromDanceFloor", distanceFromDanceFloor); // Sets the float value of the animator parameter "DistFromDanceFloor" to whatever value is being stored in distanceFromDanceFloor float variable.

        // Calculates the distance between the player and bar, stores the value in a float variable.
        distanceFromBar = Vector3.Distance(bar.position, transform.position);
        aiAnim.SetFloat("DistFromBar", distanceFromBar); // Sets the float value of the animator parameter "DistFromBar" to whatever value is being stored in distanceFromBar float variable.
        */

            //Debug.Log(randNum);
         if (aiAnimStateInfo.IsName("ElizabethWalking")) // If it's current animator state is "Walking", it will set it's destination to the test target objects position.
         {
             aiNavMeshAgent.SetDestination(danceFloor.transform.position);
             aiNavMeshAgent.isStopped = false;
         }

        /*if (aiAnimStateInfo.IsName("Fighting"))
        {
            aiNavMeshAgent.isStopped = true;
            aiAnim.SetBool("isFighting", true);

            isFighting = true;
            
        }*/

        /*if (aiAnimStateInfo.IsName("ElizabethWalking2")) // If it's current animator state is "Walking", it will set it's destination to the test target objects position.
        {
            aiNavMeshAgent.SetDestination(bar.position);
            aiNavMeshAgent.isStopped = false;
        }*/

        if (aiAnimStateInfo.IsName("ElizabethIdle") || aiAnimStateInfo.IsName("ElizabethDancing")) // If it's current animator state is "Idle" or "Dancing", it will not move.
        {
            aiNavMeshAgent.isStopped = true;
        }
    }
}
