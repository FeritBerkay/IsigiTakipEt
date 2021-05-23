using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private float moveInput;
    public Rigidbody2D rb2d;
    public GameObject playerBody;
    private bool faceRight = true;
    public float referance = 0f;
    public static bool canMove = true;
    public Animator playerAnimation;


    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGrounded;



    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGrounded);
        if (isGrounded)
        {
            canMove = true;

        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            rb2d.velocity = Vector2.up * jumpForce;
        }

        // player Animation ____________
        if (dimensionControl.isTurned)
        {
            playerAnimation.SetBool("is_turned", true);
            playerAnimation.SetBool("is_Walking", false);
            playerAnimation.SetBool("is_Jumping", false);
        }
        else
        {
            playerAnimation.SetBool("is_turned", false);
            if (isGrounded)
            {
                playerAnimation.SetBool("is_Jumping", false);
                if (moveInput != 0f)
                {
                    playerAnimation.SetBool("is_Walking", true);
                }
                else
                {
                    playerAnimation.SetBool("is_Walking", false);
                }
            }
            else if (!isGrounded)
            {
                playerAnimation.SetBool("is_Jumping", true);
                playerAnimation.SetBool("is_Walking", false);
            }
        }
        //-----------------------------
    }

    private void FixedUpdate()
    {
        if ( canMove )
        {
            moveInput = Input.GetAxis("Horizontal");
            rb2d.velocity = new Vector2(moveInput * speed, rb2d.velocity.y);
            if (moveInput < 0 && faceRight == true)
            { 
                Flip();
            }
            else if (moveInput > 0 && faceRight == false)
            {
                Flip();
            }
        }

    }

    public void Flip ()
    {
        faceRight = !faceRight;
        Vector3 Scaler = playerBody.transform.localScale;
        Scaler.x *= -1;
        playerBody.transform.localScale = Scaler;
    }
}
