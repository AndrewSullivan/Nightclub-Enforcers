using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text task1, task2, task3, task4, task5;
    public Text subHeading1, subHeading2, subHeading3, subHeading4, subHeading5;

    public GameObject endGameCanvas;

    DrinkSpawner drinkTask;
    RecordTask recordTask;

    GameTimer timer;
    GameWin gameWin;

    // Start is called before the first frame update
    void Start()
    {
        // Set's the task title text objects to each task.
        task1.text = "Bottle Clean Up Task";
        task2.text = "Wet Floor Task";
        task3.text = "Drinks Order Task";
        task4.text = "Vinyl Record Task";
        task5.text = "Drunk Customer";

        drinkTask = GameObject.Find("DrinkSpawn").GetComponent<DrinkSpawner>(); // Get's the Drink Spawner script.
        recordTask = GameObject.Find("TaskManager").GetComponent<RecordTask>(); // Get's the Record Task script.
        timer = GameObject.Find("Timer").GetComponent<GameTimer>(); // Get's the Game Timer script.
        gameWin = GameObject.Find("WinSystem").GetComponent<GameWin>(); // Get's the Game Win Script.
    }

    // Update is called once per frame
    void Update()
    {

        // Bottle Clean Up Task
        subHeading1.text = "Throw away the empty bottles around the club";

        // Wet Floor Task
        subHeading2.text = "Clean up all the puddles";

        // Drink Order Task
        subHeading3.text = "Take the " + drinkTask.chosenDrink.name + " on the stool to " + drinkTask.tableName;

        // Record Task
        subHeading4.text = "Play " + recordTask.chosenRecord.name + " on the DJ decks";

        // Drunk Customer
        subHeading5.text = "Throw out drunk customer";

        // If the timer is equal to 0, it will display the End Game Canvas game object to show the player they have lost.
        if(timer.timer <= 0f && gameWin.tasksComplete != 4)
        {
            endGameCanvas.SetActive(true);
        }
    }
}
