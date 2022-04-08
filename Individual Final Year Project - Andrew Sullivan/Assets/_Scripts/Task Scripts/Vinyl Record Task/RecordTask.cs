using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordTask : MonoBehaviour
{
    public GameObject[] records;
    public GameObject[] spawns;
    public GameObject djDecks;

    public int randomRecord;
    public GameObject chosenRecord;
    public GameObject decksTrigger;
    public GameObject decksPos;
    public string recordName;

    // Start is called before the first frame update
    void Start()
    {
        SpawnRecords();
        SpawnDecksTrigger();
    }

    void SpawnRecords()
    {
        randomRecord = Random.Range(0, records.Length);
        GameObject recordSpawn = spawns[Random.Range(0, spawns.Length)];
        Vector3 prefabSpawnRotation = new Vector3(-89.98f, 0f, 0f);
        chosenRecord = Instantiate(records[randomRecord], recordSpawn.transform.position, Quaternion.Euler(prefabSpawnRotation));

        if(randomRecord == 0)
        {
            chosenRecord.name = "Blue Record";
        }
        else if(randomRecord == 1)
        {
            chosenRecord.name = "Red Record";
        }
        else if (randomRecord == 2)
        {
            chosenRecord.name = "Green Record";
        }
        else if (randomRecord == 3)
        {
            chosenRecord.name = "Purple Record";
        }
    }

    void SpawnDecksTrigger()
    {
        djDecks = Instantiate(decksTrigger, decksPos.transform.position, Quaternion.Euler(-90,0,0));
    }
}
