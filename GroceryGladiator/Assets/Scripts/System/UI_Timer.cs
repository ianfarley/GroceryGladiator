using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Timer : MonoBehaviour
{
    public Text timerText;
    private float currentTime = 9999.0f;
    public static float levelTime;
    public static bool timeIsRunning;
    void Start()
    {
        timeIsRunning = true;
    }

    void Update()
    {
        if(timeIsRunning)
        {
            if (currentTime == 9999.0f)
            {
                currentTime = levelTime;
            }

            else if (currentTime != 9999.0f && currentTime > 0)
            {
                currentTime -= Time.deltaTime;
                ShowTime(currentTime);
            }

            else if (currentTime <= 0)
            {
                currentTime = 0.0f;
                ShowTime(currentTime);
                theGameManager.LoseTheGame();
            }
        }
    }

     public void ShowTime(float theTime)
    {
        float minute = Mathf.FloorToInt(theTime / 60);
        float second = Mathf.FloorToInt(theTime % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minute, second);
    }

    public static void SetTimer(float newTime)
    {
        levelTime = newTime;
    }
}
