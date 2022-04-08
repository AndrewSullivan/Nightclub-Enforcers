using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordChecker : MonoBehaviour
{
    RecordTask record;

    GameWin gameWin;

    AudioSource taskCompleteEffect;

    // Start is called before the first frame update
    void Start()
    {
        record = GameObject.Find("TaskManager").GetComponent<RecordTask>();
        gameWin = GameObject.Find("WinSystem").GetComponent<GameWin>();
        taskCompleteEffect = GameObject.Find("Task Complete Sound Effect").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == record.chosenRecord.gameObject.tag)
        {
            Destroy(other.gameObject);
            gameWin.tasksComplete = gameWin.tasksComplete + 1;
            taskCompleteEffect.Play();
            Debug.Log("Playing correct record!");
        }
    }
}
