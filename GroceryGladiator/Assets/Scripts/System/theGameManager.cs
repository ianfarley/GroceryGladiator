using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class theGameManager : MonoBehaviour
{
    public UI_WinLoseText winLosePanel;
    void Start()
    {

    }

    void Update()
    {
        //Reset variables when the scene is the menu
    }

    public void WonTheGame()
    {
        Debug.Log("Player has won the game!");
        PlayerMovements.canMove = false;
        winLosePanel.GetComponent<UI_WinLoseText>().OpenWinPanel();
    }

    public void LoseTheGame()
    {
        Debug.Log("Player has lost the game!");
        PlayerMovements.canMove = false;
        winLosePanel.GetComponent<UI_WinLoseText>().OpenLosePanel();
    }
}
