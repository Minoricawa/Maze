using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ster2 : MonoBehaviour
{
    [SerializeField] GameObject star;
    [SerializeField] GameObject star2;
    [SerializeField] GameObject star3;

    void Start()
    {
        star.SetActive(false);
        star2.SetActive(false);
        star3.SetActive(false);
    }

    public void SetResult(float result)
    {
        if (result < 80 && result > 60)
        {
            star.SetActive(true);
            star2.SetActive(true);
        }
        else if (result < 60)
        {
            star.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
        }
        else
        {
            star.SetActive(true);
        }
    }
}
