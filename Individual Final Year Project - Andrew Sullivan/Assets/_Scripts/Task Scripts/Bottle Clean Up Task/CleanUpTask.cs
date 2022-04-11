using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CleanUpTask : MonoBehaviour
{
    public int bottlesBinned, currentBottlesBinned;
    public int numOfBottles;
    int randomBottle;
    public GameObject[] bottles;
    public List<GameObject> bottleSpawns = new List<GameObject>();

    AudioSource taskCompleteEffect;
    
    GameWin gameWin;

    //UI uiScript;

    // Start is called before the first frame update
    void Start()
    {
        bottlesBinned = 0;

        gameWin = GameObject.Find("WinSystem").GetComponent<GameWin>();
        taskCompleteEffect = GameObject.Find("Task Complete Sound Effect").GetComponent<AudioSource>();

        for (int i = 0; i < 4; i++)
        {
            randomBottle = Random.Range(0, bottles.Length); // Chooses a random drink bottle.
            GameObject spawn = bottleSpawns[Random.Range(0, bottleSpawns.Count)]; // Chooses a random spawn position.
            Instantiate(bottles[randomBottle], spawn.transform.position, Quaternion.identity);
            Destroy(spawn.gameObject); // This prevents the same spawn position from being used again.
        }
    }

    // Update is called once per frame
    void Update()
    {
        currentBottlesBinned = bottlesBinned;

        if (bottlesBinned == 4)
        {
            Debug.Log("Congratulations, you have cleared up all the left over bottles!"); // If 5 bottles are dropped into the bin, it will send a message to the console.
            gameWin.tasksComplete = gameWin.tasksComplete + 1;
            taskCompleteEffect.Play();
            Destroy(this.gameObject); // This is to prevent it from constantly adding to the task complete value every millisecond.
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bottle")
        {
            Destroy(other.gameObject); // This destroys the bottle that is being dropped into the bin.
            bottlesBinned++; // This then increments the value of the amount of bottles that have been thrown in the bin by the player.
        }
    }
}
