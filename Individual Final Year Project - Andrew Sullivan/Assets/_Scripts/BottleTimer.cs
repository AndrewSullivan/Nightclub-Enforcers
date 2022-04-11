using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleTimer : MonoBehaviour
{
    float timer;

    private void Awake()
    {
        timer = 3f; // Set's timer variable to be 3 when the bottle is awake in the scene (e.g. instantiated in the scene).
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime; // Decreases the timer each frame.

        // If the timer reaches 0, destroy the bottle game object.
        if(timer <= 0f) 
        {
            Destroy(this.gameObject);
        }
    }
}
