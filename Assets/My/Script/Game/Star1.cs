using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star1 : MonoBehaviour
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
        if (result < 40 && result > 35)
        {
            star.SetActive(true);
            star2.SetActive(true);
        }
        else if (result < 35)
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
