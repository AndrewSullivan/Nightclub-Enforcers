using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowAIOut : MonoBehaviour
{
    AICharacter ai;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "AI")
        {
            Debug.Log("AI IN EXIT!");
            if(ai.isFighting == true)
            {
                Destroy(other.gameObject);
            }
        }
    }
}
