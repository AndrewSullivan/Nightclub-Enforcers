using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleDamage : MonoBehaviour
{
    PlayerHealth playerHealthScript;

    private void Awake()
    {
        playerHealthScript = GameObject.Find("PlayerModel").GetComponent<PlayerHealth>(); // Get's Player Health Script.
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player") // If bottle collided with Player.
        {
            playerHealthScript.playerHealth = playerHealthScript.playerHealth - 10; // Decrease the player health variable in Player Health script by 10.
        }
    }
}
