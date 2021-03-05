using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class theGameManager : MonoBehaviour
{
    public GameObject[] collectibles;
    public string[] collectibleNames;
    private int numOfCollectibles;
    void Start()
    {
        GetCollectibles();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GetCollectibles()
    {
        collectibles = GameObject.FindGameObjectsWithTag("Collectible");
        numOfCollectibles = GameObject.FindGameObjectsWithTag("Collectible").Length;
        //collectibleNames[numOfCollectibles];

        /*
        for(int x = 0; x < collectibles.Length; x++)
        {
            //collectibleNames = collectibles[x].name;
            Debug.Log("Collectible: " + collectibleNames[x] + " has been found!");
        }
        */
    }

    public void UpdateCollectibleList()
    {

    }
}
