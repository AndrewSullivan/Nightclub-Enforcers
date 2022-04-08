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

    AudioSource cleaningEffect;

    AudioSource taskCompleteEffect;

    void Start()
    {
        player = GameObject.Find("Player");
        gameWin = GameObject.Find("WinSystem").GetComponent<GameWin>();
        cleaningEffect = GameObject.Find("Cleaning Sound Effect").GetComponent<AudioSource>();
        taskCompleteEffect = GameObject.Find("Task Complete Sound Effect").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // Wet Floor Task
        distFromPlayer = Vector3.Distance(player.transform.position, this.transform.position);

        

        if (numOfClicks == 4)
        {
            puddlesCleaned = puddlesCleaned + 1;
            Destroy(this.gameObject);
        }

        if(numOfClicks == 1)
        {
            cleaningEffect.Play();
        }

        if(puddlesCleaned == 3)
        {
            complete = true;
        }

        if (complete == true)
        {
            gameWin.tasksComplete = gameWin.tasksComplete + 1;
            taskCompleteEffect.Play();
            Destroy(this.gameObject); // This is to prevent it from constantly adding to the task complete value every millisecond.
        }
    }

}
