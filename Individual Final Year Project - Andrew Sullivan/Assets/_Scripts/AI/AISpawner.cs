using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISpawner : MonoBehaviour
{
    public GameObject spawn;
    public GameObject ai;
    public float timer, delay;
    public int numOfAi;

    void Start()
    {
        SpawnAIInvoke();
    }

    void SpawnAIInvoke()
    {
        InvokeRepeating("SpawnAI", timer, delay);
    }

    void SpawnAI()
    {
        Instantiate(ai, spawn.transform.position, Quaternion.identity);
        numOfAi++;

        if (numOfAi >= 5)
        {
            CancelInvoke("SpawnAI");
        }
    }
}
