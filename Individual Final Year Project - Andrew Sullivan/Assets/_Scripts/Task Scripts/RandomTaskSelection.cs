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
    public List<GameObject> puddlePos = new List<GameObject>();
    public float timer;
    public float delay;
    int numOfPuddles = 0;

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

    void WetFloorTask()
    {
        InvokeRepeating("PuddleInstantiation", timer, delay);

    }

    void PuddleInstantiation()
    {
        GameObject spawnPos = puddlePos[Random.Range(0, puddlePos.Count)];
        Instantiate(puddle, spawnPos.transform.position, Quaternion.identity);
        Destroy(spawnPos.gameObject);
        numOfPuddles++;

        if (numOfPuddles == 3)
        {
            CancelInvoke("PuddleInstantiation");
        }
    }
}
