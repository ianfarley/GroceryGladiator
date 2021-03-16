using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_WinLoseText : MonoBehaviour
{
    public Text winText, loseText;
    public static int wonLose = 2;
    void Update()
    {
        if(wonLose != 2)
        {
            if(wonLose == 0)
            {
                loseText.gameObject.SetActive(true);
            }
            if(wonLose == 1)
            {
                winText.gameObject.SetActive(true);
            }
        }
    }

    public static void SetText(int winOrLose)
    {
        wonLose = winOrLose;
    }
}
