using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuddleTutorial : MonoBehaviour
{
    public float numOfClicks;

    float distFromPlayer;

    Transform player;

    // Start is called before the first frame update
    void Start()
    {
        numOfClicks = 0;
        player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        distFromPlayer = Vector3.Distance(player.position, this.transform.position);

        if(distFromPlayer < 5f)
        {
            if (Input.GetMouseButtonDown(0))
            {
                numOfClicks++;
            }
        }

        if(numOfClicks == 4)
        {
            Destroy(this.gameObject);
        }
    }
}
