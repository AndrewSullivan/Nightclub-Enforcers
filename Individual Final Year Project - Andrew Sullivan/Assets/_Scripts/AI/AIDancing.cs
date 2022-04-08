using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIDancing : MonoBehaviour
{
    public NavMeshAgent aiAgent;

    public Animator ai_AC;

    // Layer Masks
    public LayerMask isDanceFloor;

    // States
    public float danceFloorRadius;
    public bool onDanceFloor;

    void Awake()
    {
        aiAgent = GetComponent<NavMeshAgent>();
        ai_AC = GetComponent<Animator>();
    }

    void Update()
    {
        onDanceFloor = Physics.CheckSphere(transform.position, danceFloorRadius, isDanceFloor);

        if (onDanceFloor)
        {
            ai_AC.SetBool("isDancing", true);
        }
    }
}
