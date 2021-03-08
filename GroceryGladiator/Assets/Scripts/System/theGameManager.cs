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

    // Update is called once per frame
    void Update()
    {

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
