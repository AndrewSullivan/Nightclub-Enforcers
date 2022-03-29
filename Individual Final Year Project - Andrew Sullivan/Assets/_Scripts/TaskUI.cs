using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class TaskUI : MonoBehaviour
{

    RandomTaskSelection task;

    public Text task1;
    public Text task2;
    public Text task3;

    // Start is called before the first frame update
    void Start()
    {
        task = GameObject.Find("Task Selector").GetComponent<RandomTaskSelection>();

        task1.text = " ";
        task2.text = " ";
        task3.text = " ";
    }

    // Update is called once per frame
    void Update()
    {
        if(task.selection1 == 1)
        {
            task1.text = "Bottle Clean Up Task";
        }

        if (task.selection2 == 1)
        {
            task2.text = "Wet Floor Task";
        }

        if(task.selection3 == 1)
        {
            task3.text = "Waiter Task";        
        }

    }
}
