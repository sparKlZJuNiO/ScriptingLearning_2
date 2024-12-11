using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTest : MonoBehaviour
{
    [SerializeField] private Rigidbody rb; // Reference to RigidBody
    [SerializeField] private int jumpForce;
    [SerializeField] private int speed;
    

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); 
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0, moveVertical); // We move forward and backwards
        rb.AddForce(movement * speed); // Force is always Vector3 and makes the player move

        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(Vector3.up * jumpForce); // Makes Rigidbody jump up based on the jumpforce
            Debug.Log("Jumping");
        }
    }
}
