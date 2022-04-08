using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIBar : MonoBehaviour
{
    public NavMeshAgent aiAgent;

    Transform player;

    public Animator ai_AC;

    public bool isFighting;

    public bool isDrunk;

    public GameObject bar;

    public GameObject bottleHolder;

    public AudioSource shatterBottle;

    // AI Attack Variables
    public float attackSpacing;
    public bool hasAttacked;
    public GameObject attackBottle;

    // Layer Masks
    public LayerMask isPlayer, isBar;

    // States
    public float attackRange;
    public bool inAttackRange;
    public float barRadius;
    public bool atBar;

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

        if (atBar)
        {
            ai_AC.SetBool("isAtBar", true);
            isDrunk = true;
        }

        if (inAttackRange && isDrunk)
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
            Rigidbody rb = Instantiate(attackBottle, bottleHolder.transform.position, Quaternion.identity).GetComponent<Rigidbody>();
            
            rb.AddForce(transform.forward * 24f, ForceMode.Impulse);

            shatterBottle.Play();

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
