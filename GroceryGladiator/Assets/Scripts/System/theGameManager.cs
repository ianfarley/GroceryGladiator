using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class theGameManager : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {
        //Reset variables when the scene is the menu
    }

    public static void WonTheGame()
    {
        Debug.Log("Player has won the game!");
        PlayerMovements.canMove = false;
        UI_WinLoseText.SetText(1);
    }

    public static void LoseTheGame()
    {
        Debug.Log("Player has lost the game!");
        PlayerMovements.canMove = false;
        UI_WinLoseText.SetText(0);
    }
}
