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
        collectibleName = myObject.name;
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
            //Notify game manager that this collectible was picked up by the player
            //Signal UI to update
            //Destroy object
            Debug.Log("Destroying:" + collectibleName);
            Destroy(this.gameObject);
        }
    }
}
