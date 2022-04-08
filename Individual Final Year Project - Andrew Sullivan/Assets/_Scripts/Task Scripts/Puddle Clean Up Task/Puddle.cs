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
        player = GameObject.Find("Player").transform;
        cleaningEffect = GameObject.Find("Cleaning Sound Effect").GetComponent<AudioSource>();
        puddleTracker = GameObject.Find("TaskManager").GetComponent<PuddleTracker>();
    }

    void Update()
    {
        distFromPlayer = Vector3.Distance(player.transform.position, this.transform.position);

        if (distFromPlayer < 6f)
        {
            if (Input.GetMouseButtonDown(0))
            {
                numOfClicks++;
            }
            //Destroy(this.gameObject);
        }

        if (numOfClicks == 4)
        {
            puddleTracker.puddlesCleaned = puddleTracker.puddlesCleaned + 1;
            this.gameObject.SetActive(false);
        }

        if (numOfClicks == 1)
        {
            cleaningEffect.Play();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            numOfClicks++;
        }
    }
}
