using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorBlink : MonoBehaviour
{
    private float wait_time = 1.0f;
    private Renderer my_renderer;
    private IEnumerator coroutine;

    public Material blinkMaterial;
    private Material normalMaterial;

    // Start is called before the first frame update
    void Start()
    {
        my_renderer = GetComponent<Renderer>();
        normalMaterial = my_renderer.material;
        coroutine = WaitAndChangeColor(wait_time);
        StartCoroutine(coroutine);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void ChangeColor()
    {
        if(my_renderer.material == normalMaterial)
        {
            my_renderer.material = blinkMaterial;
        } else
        {
            my_renderer.material = normalMaterial;
        }
    }

    private IEnumerator WaitAndChangeColor(float waitTime)
    {
        while(true)
        {
            yield return new WaitForSeconds(waitTime);
            ChangeColor();
            StartCoroutine(coroutine);
        }
    }
}
