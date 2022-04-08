using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuddleBottleCleanUp : MonoBehaviour
{

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
        BinTask();
        WetFloorTask();
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
