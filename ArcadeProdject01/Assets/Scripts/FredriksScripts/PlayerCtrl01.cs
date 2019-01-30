using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerCtrl01 : MonoBehaviour
{
    public float jumpforce = 150f;
    public Rigidbody rb;
    public float MoveSpeed = 0.2f;

    bool grounded;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
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
    void OnTriggerStay(Collider trigger)
    {
       if (trigger.gameObject.tag == "Platform")
        {
            grounded = true;
        }
    }
}