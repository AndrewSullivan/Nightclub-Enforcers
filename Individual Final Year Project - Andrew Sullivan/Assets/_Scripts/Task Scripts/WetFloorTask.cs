using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WetFloorTask : MonoBehaviour
{

    GameObject player;

    public float distFromPlayer;

    int numOfClicks = 0;

    public int puddlesCleaned;

    GameWin gameWin;

    bool complete;

    void Start()
    {
        player = GameObject.Find("Player");
        gameWin = GameObject.Find("WinSystem").GetComponent<GameWin>();
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

        if(puddlesCleaned == 3)
        {
            complete = true;
        }

        if (complete == true)
        {
            gameWin.tasksComplete = gameWin.tasksComplete + 1;
            Destroy(this.gameObject); // This is to prevent it from constantly adding to the task complete value every millisecond.
        }
    }

}
