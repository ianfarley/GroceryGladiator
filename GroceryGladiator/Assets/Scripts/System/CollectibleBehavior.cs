using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectibleBehavior : MonoBehaviour
{
    public string collectibleName;
    public Image smallListCross; 
    public Image largeListCross;

    void Start()
    {
        this.collectibleName = this.gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter (Collision col)
    {
        if(col.gameObject.tag == "Player")
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
    }
}
