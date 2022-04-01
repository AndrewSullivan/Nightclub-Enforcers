using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkSpawner : MonoBehaviour
{
    public GameObject[] drinks;
    public GameObject[] tables;

    public int randomDrink;
    public GameObject chosenDrink;
    public string tableNum;
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
    }

    void ChooseTable()
    {
        int randomTable = Random.Range(0, tables.Length);

        if(randomTable == 0)
        {
            tableNum = "Table 1";
            chosenTable = Instantiate(tables[randomTable], table1Pos.transform.position, Quaternion.identity);
        }
        else
        {
            tableNum = "Table 2";
            chosenTable = Instantiate(tables[randomTable], table2Pos.transform.position, Quaternion.identity);
        }

        Debug.Log("Take "+chosenDrink+"to "+tableNum);
    }
}
