using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win_Check : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Checks if it is the player that enter the collider
        if (other.gameObject.tag == "Player")
        {
            //Trigger win condition if the player can check
            if (LevelManager.canCheckOut == true)
            {
                theGameManager.WonTheGame();
                UI_Timer.timeIsRunning = false;
            }
        }
    }
}
