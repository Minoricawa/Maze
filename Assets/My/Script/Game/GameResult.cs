using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameResult : MonoBehaviour
{
    float highScore;
    public Text resultTime;
    public Text bestTime;
    public GameObject resultUI;
    
    AudioSource audioSource = null;

    [SerializeField] Star1 start = null;

    [SerializeField] GameObject view_after = null;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        resultUI.SetActive(false);

        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScore = PlayerPrefs.GetFloat("HighScore");
        }
        else
        {
            highScore = 999;
        }

        view_after.SetActive(false);
    }


    void Update()
    {
        if (Goal.goal && Kaishi.start)
        {
            resultUI.SetActive(true);
            
            float result = Timer.time;
            resultTime.text = "ResultTime : " + Mathf.FloorToInt(Timer.time) + (Timer.time - ((int)Timer.time)).ToString("F2").TrimStart('0');
            
            audioSource.Stop();

            if (highScore > result)
            {
                PlayerPrefs.SetFloat("HighScore", result);
                highScore = result;
            }

            bestTime.text = "BestTime : " + Mathf.FloorToInt(highScore) + (highScore - ((int)highScore)).ToString("F2").TrimStart('0');
            
            start.SetResult(result);

            StartCoroutine("ViewAfter");
        }
    }


    public void OnRetry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void OnReturn()
    {
        SceneManager.LoadScene("Menu");
    }

    private IEnumerator ViewAfter()
    {
        // コルーチンの処理  
        yield return new WaitForSeconds(2.0f);

        view_after.SetActive(true);
    }

}
