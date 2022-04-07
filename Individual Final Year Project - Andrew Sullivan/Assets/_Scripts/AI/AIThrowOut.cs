using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIThrowOut : MonoBehaviour
{
    AI ai;

    private void Awake()
    {
        ai = GameObject.Find("AIModel").GetComponent<AI>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "AI" && ai.isFighting == true)
        {
            Destroy(other.gameObject);
        }
    }
}
