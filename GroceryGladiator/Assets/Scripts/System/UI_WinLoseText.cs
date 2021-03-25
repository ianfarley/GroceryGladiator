using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_WinLoseText : MonoBehaviour
{
    public GameObject winPanel, losePanel;
    public Text playerIngredientCount, totalIngredientCount;
    public static int wonLose = 2;
    void Update()
    {

    }

    public static void SetText(int winOrLose)
    {
        wonLose = winOrLose;
    }

    public void OpenWinPanel()
    {
        winPanel.gameObject.SetActive(true);
        playerIngredientCount.text = LevelManager.correctIngredients.ToString();
        totalIngredientCount.text = LevelManager.totalNumOfCollect.ToString();
    }

    public void OpenLosePanel()
    {
        losePanel.gameObject.SetActive(true);
    }
}
