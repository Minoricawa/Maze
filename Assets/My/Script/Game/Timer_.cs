using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer_ : MonoBehaviour
{
    public static float time;

    void Start()
    {
        time = 0;
    }

    void Update()
    {
        if (Kaishi.start && !Goal_.goal)
        {
            time += Time.deltaTime;
        }
        
        string text = ((int)time).ToString("000");
        
        text += (time - ((int)time)).ToString("F2").TrimStart('0');
        

        Text TextDa = GetComponent<Text>();
        TextDa.text = "Time : " + text;
    }


}
