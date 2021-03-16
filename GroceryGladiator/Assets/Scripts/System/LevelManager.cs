using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private static GameObject[] levelCollectibles;
    private static int numOfCollectibles;
    public static List<string> nameOfCollectibles;
    public static bool canCheckOut;

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

    public static void UpdateLevelCollectibles()
    {
        //levelCollectibles = GameObject.FindGameObjectsWithTag("Collectible");
        numOfCollectibles -= 1;
        //nameOfCollectibles.Remove(collectedName);
    }
}
