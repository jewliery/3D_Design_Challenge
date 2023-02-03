using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HCI_FloorGuidance : MonoBehaviour
{
    public GameObject floorGuidance;

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
            floorGuidance.SetActive(true);
            col.GetComponent<PlayerMovement>().visited = true;
            
        }
    }
}
