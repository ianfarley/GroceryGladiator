using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleBehavior : MonoBehaviour
{
    public string collectibleName;
    public GameObject myObject;

    void Start()
    {
        myObject = this.gameObject;
        this.collectibleName = this.myObject.name;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.0f, 20.0f * Time.deltaTime, 0.0f);
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
