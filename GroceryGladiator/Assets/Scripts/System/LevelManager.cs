using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private static GameObject[] levelCollectibles; //An array to hold all collectible gameobjects
    private static int numOfCollectibles; //Gets number of ingredients on the level from levelCollectibles array
    public static List<bool> collectedIngredients; //Store ingredients when player collect. Use True or False value to calculate the number of correct ingredients
    public static int correctIngredients, totalNumOfCollect;
    public static bool canCheckOut; 
    
    void Start()
    {
        collectedIngredients = new List<bool>();
        collectedIngredients.Clear(); //useful for retrying a level
        correctIngredients = 0;
        levelCollectibles = GameObject.FindGameObjectsWithTag("Collectible");
        totalNumOfCollect = levelCollectibles.Length;
        numOfCollectibles = totalNumOfCollect;
        Debug.Log("Number of collectibles at start: " + totalNumOfCollect);
        canCheckOut = false;
        Debug.Log("Remaining Collectibles: " + numOfCollectibles);
    }

    public static void UpdateLevelCollectibles()
    {
        numOfCollectibles -= 1;
        if(numOfCollectibles > 0)
        {
            Debug.Log("Remaining Collectibles: " + numOfCollectibles);
        }
        else if (numOfCollectibles <= 0)
        {
            canCheckOut = true;
            Debug.Log("Size of collectedIngredients: " + collectedIngredients.Count);
            for(int i = 0; i < collectedIngredients.Count; i++)
            {
                if(collectedIngredients[i] == true)
                {
                    correctIngredients++;
                }
            }
            Debug.Log("Num of correct Ingredients " + correctIngredients);
            Debug.Log("Exit is now available!");
        }
    }

    public void UpdatePlayerCollection(bool incomingValue) //index is based on the checklist
    {
        Debug.Log("Adding item to cart with a value of " + incomingValue);
        collectedIngredients.Add(incomingValue);
    }
}

