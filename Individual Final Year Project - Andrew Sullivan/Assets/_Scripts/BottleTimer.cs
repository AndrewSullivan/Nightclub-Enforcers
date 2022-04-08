using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleTimer : MonoBehaviour
{
    float timer;

    private void Awake()
    {
        timer = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if(timer <= 0f)
        {
            Destroy(this.gameObject);
        }
    }
}
