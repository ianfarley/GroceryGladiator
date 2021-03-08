using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private static GameObject[] levelCollectibles;
    private static int numOfCollectibles;
    public static List<string> nameOfCollectibles;
    public static bool canCheckOut;
    public static float timer = 999.0f;
    public static float newTime;

    void Start()
    {
        levelCollectibles = GameObject.FindGameObjectsWithTag("Collectible");
        numOfCollectibles = levelCollectibles.Length;
        nameOfCollectibles = new List<string>();
        canCheckOut = false;
        for (int i = 0; i < numOfCollectibles; i++)
        {
            nameOfCollectibles.Add(levelCollectibles[i].name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(timer == 999.0f)
        {
            timer = GetTimer();
        }

        //Count down the time
        if (timer > 0 && theGameManager.hasWon == false)
        {
            timer -= Time.deltaTime;
            Debug.Log("Time Remaning: " + Mathf.RoundToInt(timer) + " seconds");
        }

        else if (timer <= 0 && theGameManager.hasWon == false)
        {
            theGameManager.LoseTheGame();
        }


        if(numOfCollectibles > 0)
        {
            Debug.Log("Remaining Collectibles: " + numOfCollectibles);
        }
        else if (numOfCollectibles <= 0)
        {
            canCheckOut = true;
            Debug.Log("Exit is now available!");
        }
    }

    public static void UpdateLevelCollectibles(string collectedName)
    {
        levelCollectibles = GameObject.FindGameObjectsWithTag("Collectible");
        numOfCollectibles -= 1;
        nameOfCollectibles.Remove(collectedName);
    }

    public static void SetTimer(float time)
    {
        newTime = time;
        Debug.Log("New time set: " + newTime);
    }

    public static float GetTimer()
    {
        if (timer == 999.00f)
        {
            Debug.Log("newTime: " + newTime);
            timer = newTime;
            Debug.Log("Setting time: " + timer);
            return timer;
        }
        else
            return timer;
    }
}
