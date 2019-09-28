using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_ : MonoBehaviour
{
    AudioSource audioSource = null;

    public static bool item;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        item = false;

    }

    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "Player")
        {
            ItemGet();
        }
    }

    void ItemGet()
    {
        Animator anim = GetComponent<Animator>();
        anim.SetBool("itemget", true);
        audioSource.Play();
        //Item_.SetActive(false);
        item = true;

        transform.position = new Vector3(4, -2, -13);
    }


}
