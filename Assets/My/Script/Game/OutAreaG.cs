using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutAreaG : MonoBehaviour
{

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            //SceneManager.LoadScene("Menu");
            col.gameObject.transform.position = new Vector3(-14, 1, 13);

        }
    }
}
