using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class theGameManager : MonoBehaviour
{
    private bool hasWon;

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
    }
}
