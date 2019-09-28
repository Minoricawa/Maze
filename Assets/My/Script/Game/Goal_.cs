using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal_ : MonoBehaviour
{
    public static bool goal;

    void Start()
    {
        goal = false;
    }


    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player" && Kaishi.start && Item.item && Item_.item)
        {
            goal = true;
        }
    }

}
