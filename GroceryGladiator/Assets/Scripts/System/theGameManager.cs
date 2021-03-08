using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class theGameManager : MonoBehaviour
{
    public static bool hasWon;

    void Start()
    {
        hasWon = false;
    }

    void Update()
    {
        //Reset variables when the scene is the menu

    }


    public static void WonTheGame()
    {
        Debug.Log("Player has won the game!");
        hasWon = true;
    }

    public static void LoseTheGame()
    {
        Debug.Log("Player has lost the game!");
        PlayerMovements.canMove = false;
    }
}
