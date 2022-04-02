using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIScript : MonoBehaviour
{
    NavMeshAgent aiAgent;
    public Transform danceFloor;
    public Animator aiAnim;

    public float distance;
    bool isMoving;
    bool isIdle;

    // Start is called before the first frame update
    void Start()
    {
        aiAgent = GetComponent<NavMeshAgent>();
        //aiAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(danceFloor.position, this.transform.position);

        aiAnim.SetFloat("DistFromDanceFloor", distance);

        if (distance < 25f)
        {
            aiAgent.SetDestination(danceFloor.position);
            isMoving = true;
        }

        /*if (isMoving == true)
        {
            aiAnim.Play("ElizabethWalking");
        }
        else if (isMoving == false)
        {
            aiAnim.Play("ElizabethIdle");
        }*/
    }
}
