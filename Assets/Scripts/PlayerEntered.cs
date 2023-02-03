using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEntered : MonoBehaviour
{
    public GameObject info;

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
            LookAtInfo(col.gameObject);
        }
    }

    void LookAtInfo(GameObject player)
    {
        player.transform.LookAt(info.transform);
        player.transform.localRotation = Quaternion.Euler(0, player.transform.eulerAngles.y, 0);

        Destroy(this);
    }
}
