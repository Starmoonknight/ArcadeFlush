using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerCtrl02 : MonoBehaviour
{
    float jumpforce = 6f;   //The force or speed that the player jump at.
    public float MoveSpeed = 0.2f; //The speed which the player move at.
    bool grounded;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerMovement();
    }

    // Playermovement moves the character with the arrowkeys.
    void PlayerMovement()   
    {
        if (Input.GetKey(KeyCode.RightArrow))   //If the right arrow key is held down the player will move to the right.
        {
            transform.position += new Vector3(MoveSpeed, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))    //If the left arrow key is held down the player will move to the left.
        {
            transform.position += new Vector3(-MoveSpeed, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && grounded == true)  //If the Up Arrow key is pushed the player jumps (Only works when the player is grounded.)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpforce);
            print("jump!");

        }
    }
    // Checks if player is grounded making jump possible.
    void OnTriggerStay2D(Collider2D trigger)
    {
        if (trigger.gameObject.CompareTag("Grounded"))
        {
            grounded = true;
            print("grounded");
        }

    }
    // Turns off grounded when character is in the air, to prevent double jump
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Grounded"))
        {
            grounded = false;
            print("Not Grounded");
        }
    }
}