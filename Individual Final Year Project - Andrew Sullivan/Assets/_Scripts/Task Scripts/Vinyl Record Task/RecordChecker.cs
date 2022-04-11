using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordChecker : MonoBehaviour
{
    RecordTask record;

    GameWin gameWin;

    AudioSource taskCompleteEffect;

    // Start is called before the first frame update
    void Start()
    {
        record = GameObject.Find("TaskManager").GetComponent<RecordTask>(); // Get's Record Task script.
        gameWin = GameObject.Find("WinSystem").GetComponent<GameWin>(); // Get's Game Win script.
        taskCompleteEffect = GameObject.Find("Task Complete Sound Effect").GetComponent<AudioSource>(); // Get's task complete sound effect audio source.
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == record.chosenRecord.gameObject.tag) // Checks if the record game object in the trigger is the correct record.
        {
            Destroy(other.gameObject); // Destroys record
            gameWin.tasksComplete = gameWin.tasksComplete + 1; // Increments tasks complete variable from Game Win script by 1.
            taskCompleteEffect.Play(); // Plays task complete sound effect.
        }
    }
}
