using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private bool canMove; //Boolean to disable/enable movement
    private bool isRotating;
    private bool hasCollided;
    private Vector3 originalPos; //OriginalPos saves player location and used for collision check
    private Vector3 targetPos;  //Mark the intended position the player will go
    private Vector3 targetRot; //new rotation value after a key press

    void Start()
    {
        targetPos = transform.position;
        canMove = true;
        isRotating = false;
        hasCollided = false;
    }

    void Update()
    {
        GetMoveKey();
    }

    public void GetMoveKey()
    {
        //Move forward by the value of 1 based on player's facing direction
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            originalPos = transform.position;
            targetPos += transform.forward;

            //Can move if the player is not rotating and has the option to move
            if (canMove == true && isRotating == false)
            {
                MovePlayer(targetPos);
            }
        }

        //Turn 180 degree and move toward that direction
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (canMove == true && isRotating == false)
            {
                StartCoroutine(RotatePlayer(Vector3.up, 180, 0.75f));
            }
        }

        //Turn 90 to the character's right and move toward that direction
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (canMove == true && isRotating == false)
            {
                StartCoroutine(RotatePlayer(Vector3.up, 90, 0.75f));
            }
        }

        //Turn 90 to the character's left and move toward that direction
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (canMove == true && isRotating == false)
            {
                StartCoroutine(RotatePlayer(Vector3.up, -90, 0.75f));
            }
        }
    }

    private void MovePlayer(Vector3 destinationPos)
    {
        originalPos = transform.position;
        canMove = false;
        //Disable further movement input until character reaches targetPos
        while (transform.position != targetPos && hasCollided == false)
        {
            transform.position = Vector3.Lerp(transform.position, targetPos, 0.1f * Time.deltaTime);


            //Do a collision check here
            //If a player collides with anything, set targetPos as originalPos

            //Because move towards may never set the player's position value as an integer,
            //immediately "warp" player to the exact position
            if (Vector3.Distance(transform.position, targetPos) < 0.005f)
            {
                transform.position = new Vector3(targetPos.x, targetPos.y, targetPos.z);
            }
        }

        if (hasCollided == true)
        {
            Debug.Log("Resetting player's location....");
            targetPos = originalPos;
            transform.position = new Vector3(targetPos.x, targetPos.y, targetPos.z);
        }

        canMove = true;
        hasCollided = false;
        originalPos = transform.position;
    }

    IEnumerator RotatePlayer(Vector3 axis, float angle, float duration)
    {
        isRotating = true;
        canMove = false;
        Quaternion currentRot = transform.rotation;
        Quaternion newRot = transform.rotation;
        newRot *= Quaternion.Euler(axis * angle);

        float elaspedTime = 0.0f;

        while(elaspedTime < duration)
        {
            transform.rotation = Quaternion.Slerp(currentRot, newRot, elaspedTime / duration);
            elaspedTime += Time.deltaTime;
            yield return null;

        }
        canMove = true;
        isRotating = false;
        transform.rotation = newRot;
        transform.position = originalPos;
    }

    void OnCollisionEnter(Collision obj)
    {
        if(obj.gameObject.tag=="Obstacle")
        {
            targetPos = originalPos;
            hasCollided = true;
            Debug.Log("Hit something!");
        }                
    }
}
