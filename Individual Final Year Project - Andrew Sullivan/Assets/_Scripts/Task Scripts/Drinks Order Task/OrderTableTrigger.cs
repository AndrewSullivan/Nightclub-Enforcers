using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderTableTrigger : MonoBehaviour
{
    DrinkSpawner drink;

    GameWin gameWin;

    AudioSource taskCompleteEffect;

    // Start is called before the first frame update
    void Start()
    {
        drink = GameObject.Find("DrinkSpawn").GetComponent<DrinkSpawner>();
        gameWin = GameObject.Find("WinSystem").GetComponent<GameWin>();
        taskCompleteEffect = GameObject.Find("Task Complete Sound Effect").GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == drink.chosenDrink.gameObject.tag)
        {
            Destroy(other.gameObject);
            gameWin.tasksComplete = gameWin.tasksComplete + 1;
            taskCompleteEffect.Play();
            Debug.Log("Order Complete!");
        }
    }
}
