using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObj : MonoBehaviour
{
    public float speed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(Vector3.left, 45 * Time.deltaTime * speed);
        transform.Rotate(Vector3.up, 45 * Time.deltaTime * speed);
    }
}
