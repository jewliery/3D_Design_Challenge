using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour
{
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
            if(col.GetComponent<PlayerMovement>().visited)
            {
                SceneManager.LoadScene("HCI_LAB_ROOM", LoadSceneMode.Single);
            }
        }
    }
}
