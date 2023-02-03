using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public float wait_time = 10.0f;
    private Color randomColor;
    private Renderer my_renderer;
    private IEnumerator coroutine;

    // Start is called before the first frame update
    void Start()
    {
        my_renderer = GetComponent<Renderer>();
        coroutine = WaitAndChangeColor(wait_time);
        StartCoroutine(coroutine);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void ChangeColor()
    {
        randomColor = new Color((float) Random.Range(0,1F),(float) Random.Range(0,1F),(float) Random.Range(0,1F), 1.0f);
        my_renderer.material.color = randomColor;
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
