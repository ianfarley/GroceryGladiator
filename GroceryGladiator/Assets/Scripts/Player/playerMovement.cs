using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private bool canMove; //Boolean to disable/enable movement
    private Vector3 originalPos; //OriginalPos saves player location and used for collision check
    private Vector3 targetPos;  //Mark the intended position the player will go
    private Vector3 targetRot; //new rotation value after a key press
    private float rotValue;
    private float timeToMove = 1.0f;
    void Start()
    {
        targetPos = transform.position;
        canMove = true;
    }

    void Update()
    {
        GetMoveKey();
    }

    public void GetMoveKey()
    {
        //Move forward by the value of 1 based on player's facing direction
        //Can only if canMove is true
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) && canMove)
        {
            originalPos = transform.position;
            targetPos += transform.forward;
            //Debug.Log("New position:" + targetPos.x + ", " + targetPos.y + ", " + targetPos.z);

            MovePlayer(targetPos);
        }

        //Turn 180 degree and move toward that direction
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow) && canMove)
        {
            StartCoroutine(RotatePlayer(Vector3.up, 180, 0.5f));
        }

        //Turn 90 to the character's right and move toward that direction
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow) && canMove)
        {
            StartCoroutine(RotatePlayer(Vector3.up, 90, 0.5f));
        }


        //Turn 90 to the character's left and move toward that direction
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow) && canMove)
        {
            StartCoroutine(RotatePlayer(Vector3.up, -90, 0.5f));
        }
    }

    private void MovePlayer(Vector3 destinationPos)
    {
        //Disable further movement input until character reaches targetPos
        while (transform.position != targetPos)
        {
            canMove = false;
            transform.position = Vector3.Lerp (transform.position, targetPos, 1.0f * Time.deltaTime);


            //Do a collision check here
            //If a player collides with anything, set targetPos as originalPos



            //Because move towards may never set the player's position value as an integer,
            //immediately "warp" player to the exact position
            if (Vector3.Distance(transform.position, targetPos) < 0.005f)
            {
                transform.position = targetPos;
            }
        }
        canMove = true;
        originalPos = transform.position;
    }

    IEnumerator RotatePlayer(Vector3 axis, float angle, float duration)
    {
        canMove = false;
        Quaternion currentRot = transform.rotation;
        Quaternion newRot = transform.rotation;
        newRot *= Quaternion.Euler(axis * angle);

        float elaspedTime = 0.0f;

        while(elaspedTime < duration)
        {
            canMove = false;
            transform.rotation = Quaternion.Slerp(currentRot, newRot, elaspedTime / duration);
            elaspedTime += Time.deltaTime;
            yield return null;
        }
        canMove = true;
        transform.rotation = newRot;
    }
}
