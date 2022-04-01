using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordChecker : MonoBehaviour
{
    RecordTask record;

    // Start is called before the first frame update
    void Start()
    {
        record = GameObject.Find("RecordSpawner").GetComponent<RecordTask>();
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
            Debug.Log("Playing correct record!");
        }
    }
}
