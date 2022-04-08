using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    public NavMeshAgent aiAgent;

    Transform player;

    Animator ai_AC;

    public bool isFighting;

    public bool isDrunk;

    public GameObject bar;

    // AI Attack Variables
    public float attackSpacing;
    bool hasAttacked;
    public GameObject attackBottle;

    // Layer Masks
    public LayerMask isPlayer, isBar, isDanceFloor;

    // States
    public float attackRange;
    public bool inAttackRange;
    public float barRadius;
    public bool atBar;
    public float danceFloorRadius;
    public bool onDanceFloor;

    void Awake()
    {
        player = GameObject.Find("Player").transform;
        aiAgent = GetComponent<NavMeshAgent>();
        ai_AC = GetComponent<Animator>();

    }

    void Update()
    {
        // Check if player is in view range and in attack range
        inAttackRange = Physics.CheckSphere(transform.position, attackRange, isPlayer);

        atBar = Physics.CheckSphere(transform.position, barRadius, isBar);

        onDanceFloor = Physics.CheckSphere(transform.position, danceFloorRadius, isDanceFloor);

        float distFromBar = Vector3.Distance(transform.position, bar.transform.position);

        ai_AC.SetFloat("DistFromBar", distFromBar);

        if(distFromBar < 6)
        {
            aiAgent.SetDestination(bar.transform.position);
        }

        if (atBar)
        {
            ai_AC.SetBool("isAtBar", true);
            isDrunk = true;
        }

        if (inAttackRange && isDrunk)
        {
            Attack();
        }

        if (onDanceFloor)
        {
            ai_AC.SetBool("isDancing", true);
        }
    }

    void Attack()
    {
        aiAgent.SetDestination(transform.position); // Stops the AI character from moving when attacking.

        transform.LookAt(player); // Makes the AI face towards the player when it is attacking.

        isFighting = true;

        ai_AC.SetBool("isThrowing", true);

        if (!hasAttacked)
        {
            Rigidbody rb = Instantiate(attackBottle, transform.position, Quaternion.identity).GetComponent<Rigidbody>();
            
            rb.AddForce(transform.forward * 32f, ForceMode.Impulse);
            //rb.AddForce(transform.up * 8f, ForceMode.Impulse);

            hasAttacked = true;
            Invoke("DelayAttack", attackSpacing);
        }
    }

    void DelayAttack()
    {
        hasAttacked = false;
        ai_AC.SetBool("isThrowing", false);
    }
}
