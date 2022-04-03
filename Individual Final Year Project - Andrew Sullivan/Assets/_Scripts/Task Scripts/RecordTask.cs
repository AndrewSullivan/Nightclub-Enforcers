using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordTask : MonoBehaviour
{
    public GameObject[] records;
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
        chosenRecord = Instantiate(records[randomRecord], transform.position, Quaternion.identity);

        if(randomRecord == 0)
        {
            recordName = "Blue Record";
        }
        else if(randomRecord == 1)
        {
            recordName = "Red Record";
        }
        else if (randomRecord == 2)
        {
            recordName = "Green Record";
        }
        else if (randomRecord == 3)
        {
            recordName = "Purple Record";
        }
    }

    void SpawnDecksTrigger()
    {
        djDecks = Instantiate(decksTrigger, decksPos.transform.position, Quaternion.identity);
    }
}
