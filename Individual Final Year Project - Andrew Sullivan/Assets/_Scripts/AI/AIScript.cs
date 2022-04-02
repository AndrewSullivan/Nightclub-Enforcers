using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIScript : MonoBehaviour
{
    NavMeshAgent aiAgent;
    public Transform danceFloor;
    public Transform bar;
    public Animator aiAnim;

    public float distanceDanceFloor;
    public float distanceBar;
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

        // Dance Floor
        distanceDanceFloor = Vector3.Distance(danceFloor.position, this.transform.position);

        aiAnim.SetFloat("DistFromDanceFloor", distanceDanceFloor);

        if (distanceDanceFloor < 25f)
        {
            aiAgent.SetDestination(danceFloor.position);
            isMoving = true;
        }

        // Bar
        distanceBar = Vector3.Distance(bar.position, this.transform.position);

        aiAnim.SetFloat("DistFromBar", distanceBar);

        if (distanceBar < 25f)
        {
            aiAgent.SetDestination(bar.position);
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
