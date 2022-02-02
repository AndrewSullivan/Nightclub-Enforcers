using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanUpTask : MonoBehaviour
{
    int bottlesBinned;

    // Start is called before the first frame update
    void Start()
    {
        bottlesBinned = 0;   
    }

    // Update is called once per frame
    void Update()
    {
        if(bottlesBinned == 1)
        {
            Debug.Log("Congratulations, you have cleared up all the left over bottles!"); // If 5 bottles are dropped into the bin, it will send a message to the console.
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bottle")
        {
            Destroy(other.gameObject); // This destroys the bottle that is being dropped into the bin.
            bottlesBinned++; // This then increments the value of the amount of bottles that have been thrown in the bin by the player.
        }
    }
}
