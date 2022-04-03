using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWin : MonoBehaviour
{
    public int tasksComplete = 0;

    // Update is called once per frame
    void Update()
    {
        if(tasksComplete >= 4)
        {
            Application.Quit();
            Debug.Log("All tasks completed");
        }
    }
}
