using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puddle : MonoBehaviour
{
    public int numOfClicks;

    public int puddlesCleaned;

    float distFromPlayer;

    Transform player;

    AudioSource cleaningEffect;

    PuddleTracker puddleTracker;

    // Start is called before the first frame update
    void Start()
    {
        numOfClicks = 0;
        player = GameObject.Find("Player").transform; // Get's transform of player.
        cleaningEffect = GameObject.Find("Cleaning Sound Effect").GetComponent<AudioSource>(); // Get's audio source.
        puddleTracker = GameObject.Find("TaskManager").GetComponent<PuddleTracker>(); // Get's PuddleTracker script.
    }

    void Update()
    {
        distFromPlayer = Vector3.Distance(player.transform.position, this.transform.position); // Calculates distance between player and puddle.

        if (distFromPlayer < 6f)
        {
            if (Input.GetMouseButtonDown(0))
            {
                numOfClicks++; // Increments numOfClicks variable by 1.
            }
        }

        if (numOfClicks == 4)
        {
            puddleTracker.puddlesCleaned = puddleTracker.puddlesCleaned + 1; // Increments puddlesCleaned variable in PuddleTracker script by 1.
            this.gameObject.SetActive(false); // Set's puddle game object to be invisible.
        }

        if (numOfClicks == 1)
        {
            cleaningEffect.Play(); // Play's cleaning sound effect when puddle is clicked on once.
        }
    }
}
