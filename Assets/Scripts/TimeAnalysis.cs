using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeAnalysis : MonoBehaviour
{
    private float enterTime;
    private float exitTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            enterTime = Time.time;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if(col.tag == "Player")
        {
            exitTime = Time.time;
            float timeDiff = exitTime - enterTime;
            Debug.Log("Time spent in Area: " + timeDiff);
        }
    }
}
