using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIThrowOut : MonoBehaviour
{
    AIBar aiBar;

    private void Awake()
    {
        aiBar = GameObject.Find("AIModel(Bar)").GetComponent<AIBar>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "AI" && aiBar.isFighting == true)
        {
            Destroy(other.gameObject);
        }
    }
}
