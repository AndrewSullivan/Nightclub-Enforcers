using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WetFloorTask : MonoBehaviour
{

    GameObject player;

    public float distFromPlayer;

    int numOfClicks = 0;

    public int puddlesCleaned = 0;

    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // Wet Floor Task
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
            Destroy(this.gameObject);
            puddlesCleaned++;
        }
    }

}
