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
    public int randChoice;
    //public int randChoice2;

    // Start is called before the first frame update
    void Start()
    {
        aiAgent = GetComponent<NavMeshAgent>();
        //aiAnim = GetComponent<Animator>();

        randChoice = Random.Range(0, 2);
        //randChoice2 = Random.Range(0, 2);
    }

    // Update is called once per frame
    void Update()
    {

        if(randChoice == 0)
        {
            aiAgent.SetDestination(danceFloor.position);
            aiAnim.SetInteger("Random Choice 1", randChoice);
        }
        else if(randChoice == 1)
        {
            aiAgent.SetDestination(bar.position);
            aiAnim.SetInteger("Random Choice 1", randChoice);
        }

        /*if (randChoice2 == 0)
        {
            aiAgent.SetDestination(danceFloor.position);
            aiAnim.SetInteger("Random Choice 2", randChoice2);
        }
        else if (randChoice2 == 1)
        {
            aiAgent.SetDestination(bar.position);
            aiAnim.SetInteger("Random Choice 2", randChoice2);
        }*/

        // Dance Floor
        distanceDanceFloor = Vector3.Distance(danceFloor.position, this.transform.position);

        aiAnim.SetFloat("DistFromDanceFloor", distanceDanceFloor);

        /*if (distanceDanceFloor < 25f)
        {
            aiAgent.SetDestination(danceFloor.position);
            isMoving = true;
        }*/

        // Bar
        distanceBar = Vector3.Distance(bar.position, this.transform.position);

        aiAnim.SetFloat("DistFromBar", distanceBar);

        /*if (distanceBar < 25f)
        {
            aiAgent.SetDestination(bar.position);
            isMoving = true;
        }*/

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
