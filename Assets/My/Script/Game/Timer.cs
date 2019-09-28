using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float time;

    void Start()
    {
        time = 0;
    }

   void Update()
    {
        if(Kaishi.start && !Goal.goal)
        {
            time += Time.deltaTime;
        }
        
        // 先に整数の部分を先に書式指定する
        string text = ((int)time).ToString("000");
        // 次に小数部分のみを計算して書式指定を行う
        text += (time - ((int)time)).ToString("F2" ).TrimStart('0');
        // 出力結果
        // >text = 000123.46    

        //Textコンポーネントを「TextDa」に入れている
        Text TextDa = GetComponent<Text>();
        TextDa.text = "Time : " + text;
    }


}
