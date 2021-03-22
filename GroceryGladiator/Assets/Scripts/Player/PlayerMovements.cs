using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public GameObject playerObj;
    public GameObject bodyCam;
    private Rigidbody playerRig;
    public float playerMoveSpeed = 200.0f;
    public float playerRotationSpeed = 50.0f;
    public static bool canMove;
    [SerializeField] private Animator anim;

    void Start()
    {
        canMove = true;
        playerRig = gameObject.GetComponent<Rigidbody>();
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove == true)
        {
            //Move the player forward
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                anim.SetBool("isMoving", true);
                playerRig.AddForce(transform.forward * (playerMoveSpeed * Time.fixedDeltaTime));
            }

            //Move the player backward
            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                //anim.SetBool("isMoving", true);
                playerRig.AddForce(-transform.forward * (playerMoveSpeed * Time.fixedDeltaTime));
            }

            //Turn 90 to the character's right
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                //anim.SetBool("isMoving", true);
                transform.Rotate(Vector3.up * (playerRotationSpeed * Time.fixedDeltaTime));
            }

            //Turn 90 to the character's left
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
               //anim.SetBool("isMoving", true);
                transform.Rotate(Vector3.down * (playerRotationSpeed * Time.fixedDeltaTime));
            }

            else if(!Input.anyKey)
            {
                anim.SetBool("isMoving", false);
            }
        }

        else if (canMove == false)
        {
            //Player cannot move!
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Grandma")
        {
            
            canMove = false;
            anim.SetBool("isMoving", false);
            playerRig.AddForce(-transform.forward * 750.0f);
            //StartCoroutine(spinMe());
            StartCoroutine(stunMe());
        }
    }

    private void OnColliderEnter(Collider col)
    {
        if(col.gameObject.tag == "Fart")
        {
            playerMoveSpeed = 100.0f;
        }
    }

    private void OnColliderExit(Collider col)
    {
        if(col.gameObject.tag == "Fart")
        {
            playerMoveSpeed = 200.0f;
        }    
    }
    /*
    IEnumerator spinMe()
    {
        float i = 0.0f;
        float stunTime = 3.0f;
        bodyCam.transform.parent = null;
        while (i < stunTime)
        {
            transform.Rotate(Vector3.up * 3.0f);
            i += Time.fixedDeltaTime;
            yield return null;
        }
        bodyCam.transform.parent = playerObj.transform;
        canMove = true;
    }
    */

    IEnumerator stunMe()
    {
        yield return new WaitForSeconds(2.0f);
        canMove = true;
    }
}
