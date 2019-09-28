using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cushion : MonoBehaviour
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
        SceneManager.LoadScene("Stage1");
    }
   
    IEnumerator Voice()
    {
        yield return new WaitForSeconds(1.0f);
        audioSource.Play();
    }

}
