using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_FaceToCamera : MonoBehaviour
{
    public GameObject playerObject;
    private float pickupRange = 3.0f;
    public GameObject myButton; 

    void Start()
    {
        myButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Camera cam = Camera.main;
        transform.LookAt(transform.position + cam.transform.rotation * Vector3.forward, cam.transform.rotation * Vector3.up);

        if ((Vector3.Distance(playerObject.transform.position, this.gameObject.transform.position) <= pickupRange))
        {
            myButton.gameObject.SetActive(true);
        }
        else if (Vector3.Distance(playerObject.transform.position, this.gameObject.transform.position) > pickupRange)
        {
            myButton.gameObject.SetActive(false);
        }
    }
}
