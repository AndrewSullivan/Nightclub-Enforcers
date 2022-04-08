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
    OrderTableTrigger drinkOrder;
    RecordTask recordTask;

    GameTimer timer;

    // Start is called before the first frame update
    void Start()
    {
        task1.text = "Bottle Clean Up Task";
        task2.text = "Wet Floor Task";
        task3.text = "Drinks Order Task";
        task4.text = "Vinyl Record Task";
        task5.text = "Drunk Customer";

        subHeading1.text = "";
        subHeading2.text = "";
        subHeading3.text = "";
        subHeading4.text = "";
        subHeading5.text = "";

        drinkTask = GameObject.Find("DrinkSpawn").GetComponent<DrinkSpawner>();
        recordTask = GameObject.Find("TaskManager").GetComponent<RecordTask>();
        timer = GameObject.Find("Timer").GetComponent<GameTimer>();
    }

    // Update is called once per frame
    void Update()
    {
        //aiScript = GameObject.Find("AI").GetComponent<AIScript>();

        // Bottle Clean Up Task
        subHeading1.text = "Throw away the empty bottles around the club";

        // Wet Floor Task
        subHeading2.text = "Clean up all the puddles";

        // Drink Order Task
        subHeading3.text = "Take the " + drinkTask.chosenDrink.name + " on the stool to " + drinkTask.tableNum;

        // Record Task
        subHeading4.text = "Play " + recordTask.chosenRecord.name + " on the DJ decks";

        // Drunk Customer
        subHeading5.text = "Throw out drunk customer";

        if(timer.timer <= 0f)
        {
            endGameCanvas.SetActive(true);
        }
    }
}
