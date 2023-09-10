using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerModel playerModel;
    private bool isGrounded;
    private int jumpsRemaining = 2;

    public float groundCheckDistance = 1;
    public LayerMask groundLayer;

    public float moveSpeed = 5f;
    public float jumpForce = 7f;
    

    private void Awake()
    {
        playerModel = GetComponent<PlayerModel>();
    }

    private void Update()
    {
        // Check if the player is grounded
        isGrounded = Physics.Raycast(transform.position, Vector3.down, groundCheckDistance, groundLayer);
        
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0);

        // Move the player
        playerModel.Move(movement, moveSpeed);

        // Handle jumping
        if (Input.GetButtonDown("Jump") && jumpsRemaining > 0)
        {
            playerModel.Jump(jumpForce);
            jumpsRemaining--;
        }

        // Handle attacking
        if (Input.GetButtonDown("Fire1"))
        {
            playerModel.Attack();
        }

        // Reset jumps when grounded
        if (isGrounded)
        {
            jumpsRemaining = 1;
        }
    }
}
