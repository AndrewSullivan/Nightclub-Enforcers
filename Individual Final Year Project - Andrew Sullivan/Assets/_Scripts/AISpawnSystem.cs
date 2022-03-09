using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISpawnSystem : MonoBehaviour
{
    public GameObject aiCharacter;
    public float timer;
    public float delay;
    bool stopSpawning = false;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAI", timer, delay); // This function allows the spawning function to be executed repeatedly based on the defined timer and delay.
    }

    void SpawnAI()
    {
        Instantiate(aiCharacter, transform.position, transform.rotation); // This instantiates the character on specified spawn points (empty game objects placed around the game world).
        if (stopSpawning == true)
        {
            CancelInvoke("SpawnAI"); // This stops the invoke function from being executed.
        }
    }

}
