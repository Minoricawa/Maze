using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    AudioSource audioSource = null;

    void sound()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }

}
