using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Rigidbody rb;
    public float moveSpeed = 5f; // Adjust the speed as needed

    private void Start()
    {
        // Get the Rigidbody component attached to the GameObject
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Handle input for movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Create a movement vector based on input
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);

        // Apply the movement to the Rigidbody
        rb.velocity = movement * moveSpeed;
    }
}