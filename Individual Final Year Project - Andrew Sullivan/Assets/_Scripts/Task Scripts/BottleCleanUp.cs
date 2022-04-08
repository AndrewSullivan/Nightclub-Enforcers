using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleCleanUp : MonoBehaviour
{

    // Bottle Clean Up Task 
    public GameObject bin;
    public GameObject binSpawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        BinTask();
    }

    void BinTask()
    {
        Instantiate(bin, binSpawnPosition.transform.position, Quaternion.identity); // Instantiates the bin model in the scene as it is needed for the clean up task.
    }

}
