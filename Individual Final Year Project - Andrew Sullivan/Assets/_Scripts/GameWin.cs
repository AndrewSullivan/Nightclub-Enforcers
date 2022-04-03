using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWin : MonoBehaviour
{
    public int tasksComplete;

    public GameObject gameWinCanvas;

    // Update is called once per frame
    void Update()
    {
        if(tasksComplete >= 4)
        {
            gameWinCanvas.SetActive(true);

            Cursor.lockState = CursorLockMode.Confined;
        }
    }
}
