using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutArea : MonoBehaviour
{

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            //SceneManager.LoadScene("Menu");
            col.gameObject.transform.position = new Vector3(0, 1, 0);

        }
    }

}
