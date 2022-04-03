using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{

    public float timer;
    public Text timerText;
    public GameObject gameLoseCanvas;

    // Start is called before the first frame update
    void Start()
    {
        timer = 60f;
    }

    // Update is called once per frame
    void Update()
    {

        timerText.text = ""+timer;

        if(timer <= 0f)
        {
            timerFinished();
        }
        else if(timer != 0f)
        {
            Time.timeScale = 1;
        }
    }

    private void FixedUpdate()
    {
        timer -= Time.deltaTime;
    }

    void timerFinished()
    {
        gameLoseCanvas.SetActive(true);
    }
}
