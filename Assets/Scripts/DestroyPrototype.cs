using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPrototype : MonoBehaviour
{
    public GameObject particles;
    public GameObject spotlight;
    public GameObject prototype_prefab;
    public GameObject podium;
    public Transform position_prototype;

    private GameObject prototype;
    private bool instantiated = false;
    private IEnumerator coroutine;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {   
    }

    void OnTriggerStay(Collider col)
    {
        if(!instantiated)
        {
            InstantiatePrototype();
        }

        if((col.tag == "Player") && Input.GetKeyDown(KeyCode.E))
        {
            DestroyPrototypeX();
        }
    }

    void DestroyPrototypeX()
    {
        if(particles != null)
        {
            Destroy(particles);
        }
        if(spotlight!=null)
        {
            Destroy(spotlight);
        }
        if(prototype!=null)
        {
            Rigidbody m_rigidbody = prototype.GetComponent<Rigidbody>();
            m_rigidbody.isKinematic = false;
            m_rigidbody.AddForce(Vector3.left * 40.0f);
        }
        if(podium!=null)
        {
            AudioSource m_audio = podium.GetComponent<AudioSource>();
            m_audio.mute = true;
        }
        AudioSource audio_throw = GetComponent<AudioSource>();
        audio_throw.Play();

        coroutine = WaitAndDestroy(3.0f);
        StartCoroutine(coroutine);
    }

    void InstantiatePrototype()
    {
        prototype = Instantiate(prototype_prefab, position_prototype.position, Quaternion.identity);
        particles.SetActive(true);
        instantiated = true;
    }

    private IEnumerator WaitAndDestroy(float waitTime)
    {
        while(true)
        {
            yield return new WaitForSeconds(waitTime);
            Destroy(prototype);
        }
    }
}
