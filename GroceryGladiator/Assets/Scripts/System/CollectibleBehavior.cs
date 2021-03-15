using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleBehavior : MonoBehaviour
{
    public string collectibleName;

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

            //Destroy object
            Debug.Log("Destroying object named: " + collectibleName);
            Destroy(this.gameObject);
        }
    }
}
