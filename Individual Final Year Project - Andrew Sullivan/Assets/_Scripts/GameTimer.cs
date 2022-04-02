using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{

    float timer;
    public Text timerText;

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
    }

    private void FixedUpdate()
    {
        timer -= Time.deltaTime;
    }

    void timerFinished()
    {
        timerText.text = "Time Ended";
    }
}
