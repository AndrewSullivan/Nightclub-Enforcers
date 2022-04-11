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
        drink = GameObject.Find("DrinkSpawn").GetComponent<DrinkSpawner>(); // Get's DrinkSpawner script.
        gameWin = GameObject.Find("WinSystem").GetComponent<GameWin>(); // Get's GameWin script.
        taskCompleteEffect = GameObject.Find("Task Complete Sound Effect").GetComponent<AudioSource>(); // Get's audio source.
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == drink.chosenDrink.gameObject.tag)
        {
            Destroy(other.gameObject); // Destroys the drink game object.
            gameWin.tasksComplete = gameWin.tasksComplete + 1; // Increments the tasks complete variable by 1.
            taskCompleteEffect.Play(); // Plays audio source for task completion sound effect.
        }
    }
}
