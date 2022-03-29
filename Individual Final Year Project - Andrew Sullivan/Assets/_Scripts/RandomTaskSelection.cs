using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTaskSelection : MonoBehaviour
{
    // Task Selections
    public int selection1;
    public int selection2;
    public int selection3;

    // Bottle Clean Up Task 
    public GameObject bin;
    public GameObject binSpawnPosition;

    // Wet Floor Task
    public GameObject puddle;
    public GameObject puddleSpawnPosition1;
    public GameObject puddleSpawnPosition2;
    public GameObject puddleSpawnPosition3;

    public float timer;
    public float delay;
    int currentPuddles = 0;

    // Waiter Task
    //public GameObject bottle;
    //public GameObject orderPosition;

    // Start is called before the first frame update
    void Start()
    {
        // Randomly choose a number for each of the 3 integer values.
        //selection1 = Random.Range(1, 3);
        selection1 = 1;
        //selection2 = Random.Range(1, 3);
        selection2 = 1;
        //selection3 = Random.Range(1, 3);
        selection3 = 1;

        // Task Selection 1
        if (selection1 == 1) // Clean up task
        {
            BinTask();
        }
        else if (selection1 == 2)
        {
            Debug.Log("Task2");
        }
        else if (selection1 == 3)
        {
            Debug.Log("Task3");
        }

        // Task Selection 2
        if (selection2 == 1)
        {
            WetFloorTask();
        }
        else if (selection2 == 2)
        {
            Debug.Log("Selection2 - Task2");
        }
        else if (selection2 == 3)
        {
            Debug.Log("Selection2 - Task3");
        }

        // Task Selection 3
        if (selection3 == 1)
        {
            WaiterTask();
        }
        else if (selection3 == 2)
        {
            Debug.Log("Selection3 - Task2");
        }
        else if (selection3 == 3)
        {
            Debug.Log("Selection3 - Task3");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BinTask()
    {
        Instantiate(bin, binSpawnPosition.transform.position, Quaternion.identity); // Instantiates the bin model in the scene as it is needed for the clean up task.
        Debug.Log("Task1 - Bin Task");
    }

    void WaiterTask()
    {
        Debug.Log("Task1 - Waiter Task");
        
    }

    void WetFloorTask()
    {
        InvokeRepeating("WetFloorTaskInstantiation", timer, delay);
    }

    void WetFloorTaskInstantiation()
    {
        int randomPos = Random.Range(1, 3);

        if (randomPos == 1)
        {
            Instantiate(puddle, puddleSpawnPosition1.transform.position, Quaternion.identity);
            currentPuddles++;
        }
        else if (randomPos == 2)
        {
            Instantiate(puddle, puddleSpawnPosition2.transform.position, Quaternion.identity);
            currentPuddles++;
        }
        else
        {
            Instantiate(puddle, puddleSpawnPosition3.transform.position, Quaternion.identity);
            currentPuddles++;
        }

        if (currentPuddles == 3)
        {
            CancelInvoke("WetFloorTaskInstantiation"); // This stops the invoke function from being executed.
        }

        Debug.Log("Task2 - Wet Floor Task");
    }
}
