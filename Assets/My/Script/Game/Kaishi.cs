using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kaishi : MonoBehaviour
{

    public static bool start;


    AudioSource audioSource = null;

    void Start()
    {
        start = false;
        audioSource = GetComponent<AudioSource>();
    }


    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            start = true;
            audioSource.Play();
            transform.position = new Vector3(-14, -2, 13);
        }
    }

}
