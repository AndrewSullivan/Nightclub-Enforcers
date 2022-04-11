using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIDancing : MonoBehaviour
{

    public Animator ai_AC;

    // Layer Masks
    public LayerMask isDanceFloor;

    // States
    public float danceFloorRadius;
    public bool onDanceFloor;

    void Awake()
    {
        ai_AC = GetComponent<Animator>();
    }

    void Update()
    {
        // Checks if its on the dance floor.
        onDanceFloor = Physics.CheckSphere(transform.position, danceFloorRadius, isDanceFloor);

        if (onDanceFloor)
        {
            ai_AC.SetBool("isDancing", true); // Set's the animator parameter "isDancing" to be true.
        }
    }
}
