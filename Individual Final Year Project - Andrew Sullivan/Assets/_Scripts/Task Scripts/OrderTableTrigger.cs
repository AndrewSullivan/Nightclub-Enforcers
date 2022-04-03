using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderTableTrigger : MonoBehaviour
{
    DrinkSpawner drink;

    GameWin gameWin;

    // Start is called before the first frame update
    void Start()
    {
        drink = GameObject.Find("DrinkSpawn").GetComponent<DrinkSpawner>();
        gameWin = GameObject.Find("WinSystem").GetComponent<GameWin>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == drink.chosenDrink.gameObject.tag)
        {
            Destroy(other.gameObject);
            gameWin.tasksComplete++;
            Debug.Log("Order Complete!");
        }
    }
}
