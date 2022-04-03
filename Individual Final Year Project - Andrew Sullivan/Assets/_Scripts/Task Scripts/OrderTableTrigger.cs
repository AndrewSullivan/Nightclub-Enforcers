using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderTableTrigger : MonoBehaviour
{
    DrinkSpawner drink;

    // Start is called before the first frame update
    void Start()
    {
        drink = GameObject.Find("DrinkSpawn").GetComponent<DrinkSpawner>();
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
            Debug.Log("Order Complete!");
        }
    }
}
