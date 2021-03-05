using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    private Rigidbody playerRig;
    private float playerMoveSpeed = 1.5f;
    private float playerRotationSpeed = 0.1f;


    void Start()
    {
        playerRig = gameObject.GetComponent<Rigidbody>();
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        //Move the player forward
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            playerRig.AddForce(transform.forward * playerMoveSpeed);
        }

        //Move the player backward
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            playerRig.AddForce(-transform.forward * playerMoveSpeed);
        }

        //Turn 90 to the character's right
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * playerRotationSpeed);
        }

        //Turn 90 to the character's left
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.down * playerRotationSpeed);
        }
    }
}
