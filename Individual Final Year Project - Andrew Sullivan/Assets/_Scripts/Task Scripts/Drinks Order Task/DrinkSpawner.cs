using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkSpawner : MonoBehaviour
{
    public GameObject[] drinks;
    public GameObject[] tables;

    public int randomDrink;
    public GameObject chosenDrink;
    public string tableName;
    public GameObject chosenTable;
    public GameObject table1Pos, table2Pos;

    // Start is called before the first frame update
    void Start()
    {
        SpawnDrinks();
        ChooseTable();
    }

    void SpawnDrinks()
    {
        randomDrink = Random.Range(0, drinks.Length);
        chosenDrink = Instantiate(drinks[randomDrink], transform.position, Quaternion.identity);

        // These if statements below have been added to aid the task UI.
        if(randomDrink == 0)
        {
            chosenDrink.name = "Blue Drink";
        }
        else if(randomDrink == 1)
        {
            chosenDrink.name = "Red Drink";
        }
        else if(randomDrink == 2)
        {
            chosenDrink.name = "Green Drink";
        }
        else if(randomDrink == 3)
        {
            chosenDrink.name = "Purple Drink";
        }
    }

    void ChooseTable()
    {
        int randomTable = Random.Range(0, tables.Length);

        if(randomTable == 0)
        {
            tableName = "Yellow Table";
            chosenTable = Instantiate(tables[randomTable], table1Pos.transform.position, Quaternion.identity);
            chosenTable.name = tableName;
        }
        else
        {
            tableName = "Red Table";
            chosenTable = Instantiate(tables[randomTable], table2Pos.transform.position, Quaternion.identity);
            chosenTable.name = tableName;
        }

        Debug.Log("Take "+chosenDrink.name+" to "+chosenTable.name);
    }
}
