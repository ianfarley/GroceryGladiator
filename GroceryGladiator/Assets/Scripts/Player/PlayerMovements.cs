using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    private Rigidbody playerRig;
    public float playerMoveSpeed = 130.0f;
    public float playerRotationSpeed = 50.0f;
    public static bool canMove;

    void Start()
    {
        canMove = true;
        playerRig = gameObject.GetComponent<Rigidbody>();
       // DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove == true)
        {
            //Move the player forward
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                playerRig.AddForce(transform.forward * (playerMoveSpeed * Time.fixedDeltaTime));
            }

            //Move the player backward
            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                playerRig.AddForce(-transform.forward * (playerMoveSpeed * Time.fixedDeltaTime));
            }

            //Turn 90 to the character's right
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(Vector3.up * (playerRotationSpeed * Time.fixedDeltaTime));
            }

            //Turn 90 to the character's left
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(Vector3.down * (playerRotationSpeed * Time.fixedDeltaTime));
            }
        }

        else if (canMove == false)
        {
            //Player cannot move!
        }

    }
}
