using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuddleTracker : MonoBehaviour
{

    public float puddlesCleaned;

    AudioSource taskCompleteEffect;

    GameWin gameWin;

    // Start is called before the first frame update
    void Start()
    {
        puddlesCleaned = 0;
        taskCompleteEffect = GameObject.Find("Task Complete Sound Effect").GetComponent<AudioSource>();
        gameWin = GameObject.Find("WinSystem").GetComponent<GameWin>();
    }

    // Update is called once per frame
    void Update()
    {
        if(puddlesCleaned == 3)
        {
            gameWin.tasksComplete = gameWin.tasksComplete + 1;
            taskCompleteEffect.Play();
            Destroy(this); // This is to prevent it from constantly adding to the task complete value every millisecond.
        }
    }
}
