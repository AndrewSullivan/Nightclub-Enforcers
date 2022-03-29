using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaiterTask : MonoBehaviour
{
    //public GameObject bottle;
    public GameObject orderPosition;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bottle")
        {
            Debug.Log("Order Completed!");
            other.gameObject.SetActive(false);
        }
    }
}
