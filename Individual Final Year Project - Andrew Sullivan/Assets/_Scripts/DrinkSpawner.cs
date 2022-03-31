using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkSpawner : MonoBehaviour
{
    public GameObject[] drinks;

    // Start is called before the first frame update
    void Start()
    {
        SpawnDrinks();
    }

    void SpawnDrinks()
    {
        int randomDrink = Random.Range(0, drinks.Length);
        Instantiate(drinks[randomDrink], transform.position, Quaternion.identity);
    }
}
