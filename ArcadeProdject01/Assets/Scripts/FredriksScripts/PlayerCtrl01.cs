using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerCtrl01 : MonoBehaviour
{
   float jumpforce = 150f;
   // public Rigidbody rb;
    public float MoveSpeed = 0.2f;

    bool grounded;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerMovement();
    }

    void PlayerMovement() 
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(MoveSpeed, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-MoveSpeed, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.W) && grounded == true) 
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpforce);
            print("jump!");

        }
    }
    void OnTriggerStay2D(Collider2D trigger)
    {
       if (trigger.gameObject.CompareTag("Grounded"))
        {
            grounded = true;
            print("grounded");
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Grounded"))
        {
            grounded = false;
            print("Not Grounded");
        }
    }
}