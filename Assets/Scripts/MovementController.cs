using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 2f;
    [SerializeField] private float jumpForce = 5f;

    private Rigidbody2D playerRigidB;

    private bool isGrounded = true;
    private bool isFacingRight = true;
    private float xVelocity;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        DetectIsGrounded();
        MoveForward();
        Jump();
        Reorient();
    }

    private void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            playerRigidB.velocity = new Vector2(xVelocity, jumpForce);
        }
    }

    private void DetectIsGrounded()
    {
        if (playerRigidB.velocity.y != 0)
        {
            isGrounded = false;
        }
        else
        {
            isGrounded = true;
        }
    }

    private void MoveForward()
    {
        xVelocity = Input.GetAxis("Horizontal") * movementSpeed;
        playerRigidB.velocity = new Vector2(xVelocity, playerRigidB.velocity.y);
    }

    private void Reorient()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            isFacingRight = true;
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            isFacingRight = false;
        }
    }

    public bool IsFacingRight()
    {
        return isFacingRight;
    }
}
