using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cushion2 : MonoBehaviour
{
    AudioSource audioSource = null;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        StartCoroutine("Bridge");

        StartCoroutine("Voice");
    }



    IEnumerator Bridge()
    {
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene("Stage2");
    }

    IEnumerator Voice()
    {
        yield return new WaitForSeconds(0.6f);
        audioSource.Play();
    }

}
