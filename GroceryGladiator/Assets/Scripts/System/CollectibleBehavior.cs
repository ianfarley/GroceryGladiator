using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectibleBehavior : MonoBehaviour
{
    public string collectibleName;
    public Image smallListCross; 
    public Image largeListCross;
    //private bool canPick;
    public GameObject playerObject;
    private float pickupRange = 1.75f;
    void Start()
    {
       // this.canPick = false;
        this.collectibleName = this.gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {

    }
    /*
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "Pickup_Range")
        {
            this.canPick = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.name == "Pickup_Range")
        {
            this.canPick = false;
        }
    }
    */
    void OnMouseDown()
    {
        Debug.Log(this.gameObject.name + " has been clicked!");
        if (Vector3.Distance(playerObject.transform.position, this.gameObject.transform.position) < pickupRange)
        {
            //Notify level manager of collectible collected
            LevelManager.UpdateLevelCollectibles(this.collectibleName);
            //Signal UI to update
            smallListCross.gameObject.SetActive(true);
            largeListCross.gameObject.SetActive(true);

            //Destroy object
            Debug.Log("Destroying object named: " + collectibleName);
            Destroy(this.gameObject);
        }
        /*
        if (canPick)
        {
            //Notify level manager of collectible collected
            LevelManager.UpdateLevelCollectibles(this.collectibleName);
            //Signal UI to update
            smallListCross.gameObject.SetActive(true);
            largeListCross.gameObject.SetActive(true);

            //Destroy object
            Debug.Log("Destroying object named: " + collectibleName);
            Destroy(this.gameObject);
        }

        else if (!canPick)
        {
            Debug.Log(gameObject.name + " cannot be picked up. Player is too far away.");
        }
        */
    }
}
