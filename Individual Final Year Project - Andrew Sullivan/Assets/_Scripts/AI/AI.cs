using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    public NavMeshAgent aiAgent;

    Transform player;

    Animator ai_AC;

    bool isDrunk;

    public bool isFighting;

    public GameObject bar;

    // AI Attack Variables
    public float attackSpacing;
    bool hasAttacked;
    public GameObject attackBottle;

    // Layer Masks
    public LayerMask isPlayer;

    // States
    public float attackRange;
    public bool inAttackRange;

    void Awake()
    {
        player = GameObject.Find("Player").transform;
        aiAgent = GetComponent<NavMeshAgent>();
        ai_AC = GetComponent<Animator>();

        isDrunk = true;
    }

    void Update()
    {
        // Check if player is in view range and in attack range
        inAttackRange = Physics.CheckSphere(transform.position, attackRange, isPlayer);

        float distFromBar = Vector3.Distance(transform.position, bar.transform.position);

        ai_AC.SetFloat("DistFromBar", distFromBar);

        if(distFromBar < 6)
        {
            aiAgent.SetDestination(bar.transform.position);
        }

        if (inAttackRange)
        {
            Attack();
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
