using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleDamage : MonoBehaviour
{
    PlayerHealth playerHealthScript;

    private void Awake()
    {
        playerHealthScript = GameObject.Find("PlayerModel").GetComponent<PlayerHealth>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            playerHealthScript.playerHealth = playerHealthScript.playerHealth - 10;
        }
    }
}
