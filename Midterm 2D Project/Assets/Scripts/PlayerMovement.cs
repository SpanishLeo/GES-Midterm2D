using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
#region Editor Fields
    [SerializeField]
    private float speed = 8;

    [SerializeField]
    private float jumpHeight = 6;

    [SerializeField]
    private Transform groundCheckPosition;

    [SerializeField]
    private float groundCheckRadius = 0.35f;

    [SerializeField]
    private LayerMask whatIsGround;
#endregion

#region Private Fields
    private float horizontalInput;
    private bool isOnGround;
    private Rigidbody2D myRigidbody2D;
    private bool pressedJump;
    private AudioSource audioSource;
    private bool facingRight = true;
    private Animator anim;
    #endregion

    void Start ()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();

        audioSource = GetComponent<AudioSource>();

        anim = GetComponent<Animator>();
    }
	
	void Update ()
    {
        GetMovementInput();
        GetJumpInput();
        HandleJump();
        UpdateIsOnGround();
    }

    private void FixedUpdate()
    {
        HandlePlayerMovement();
        HandlePlayerAnimation();
    }

    private void GetJumpInput()
    {
        pressedJump = Input.GetButtonDown("Jump");
    }

    private void UpdateIsOnGround()
    {
        Collider2D[] groundColliders = 
            Physics2D.OverlapCircleAll(groundCheckPosition.position, groundCheckRadius, whatIsGround);

        isOnGround = groundColliders.Length > 0;
    }

    private void HandleJump()
    {
        if (pressedJump && isOnGround)
        {
            myRigidbody2D.velocity = new Vector2(myRigidbody2D.velocity.x, jumpHeight);

            audioSource.Play();

            isOnGround = false;
        }
    }

    private void GetMovementInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }

    private void HandlePlayerMovement()
    {
        myRigidbody2D.velocity =
            new Vector2(speed * horizontalInput, myRigidbody2D.velocity.y);

        if (horizontalInput > 0 && !facingRight)
        {
            Flip();
        }
        else if (horizontalInput < 0 && facingRight)
        {
            Flip();
        }
    }

    private void HandlePlayerAnimation()
    {
        anim.SetFloat("Speed", Mathf.Abs(horizontalInput));

        anim.SetFloat("vSpeed", myRigidbody2D.velocity.y);

        anim.SetBool("Ground", isOnGround);
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
