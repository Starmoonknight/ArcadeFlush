using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl01 : MonoBehaviour
{

    float jumpforce = 6f;   // The force or the speed that the player jumps at.
    public float MoveSpeed = 0.2f;  // The speed which the player moves at.

    bool grounded;

    public AudioClip Walk;
    private AudioSource source;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerMovement();
    }

    // PlayerMovement moves the character with the WASD keys (excluding the "S" key.
    void PlayerMovement() 
    {
        if (Input.GetKey(KeyCode.D))    // If the "D" key is held down the character will move to the right.
        {
            transform.position += new Vector3(MoveSpeed, 0, 0); 
        }

        if (Input.GetKey(KeyCode.A))    // If the "A" key is held down the character will move to the left.
        {
            transform.position += new Vector3(-MoveSpeed, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.W) && grounded == true)    // If the "W" key is pressed then the player will jump (Only when the player is "grounded")
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpforce);
            print("jump!");

        }
    }
    // Checks if the player is grounded, making jump possible.
    void OnTriggerStay2D(Collider2D trigger)
    {
       if (trigger.gameObject.CompareTag("Grounded"))
        {
            grounded = true;
            print("grounded");
        }
       if (trigger.gameObject.CompareTag("Stone"))
        {
            this.gameObject.transform.position = new Vector2( -3.4f, 0.87f);
            trigger.gameObject.SetActive(false);
        }

    }
    // Turns off grounded when the player is in the air. This prevents double jump.
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Grounded"))
        {
            grounded = false;
            print("Not Grounded");
        }
    }
}