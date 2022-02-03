using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rigidBody;
    BoxCollider2D boxCollider;

    [SerializeField] private LayerMask groundLayer;

    [SerializeField] private float jumpForce;

    [SerializeField] private float playerSpeed;

    private int jumpCount;
    private float width = Screen.width / 2;

    bool jumped = false;
    bool movingRight = false;
    bool movingLeft = false;

    Vector2 firstTouch;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            Vector3 TouchPos = Input.touches[i].position;
            if (TouchPos.x < width)
            {
                if (TouchPos.x < width / 4 && TouchPos.y < Screen.height / 4)
                {
                    movingLeft = true;
                    if (Input.touches[i].phase.Equals(TouchPhase.Ended))
                    {
                        movingLeft = false;
                    }
                }
                if (TouchPos.x > width / 4 && TouchPos.y < Screen.height / 4)
                {
                    movingRight = true;
                    if (Input.touches[i].phase.Equals(TouchPhase.Ended))
                    {
                        movingRight = false;
                    }
                }
            }
            if (TouchPos.x > width)
            {
                if (Input.touches[i].phase.Equals(TouchPhase.Began))
                {
                    firstTouch = Input.touches[i].position;
                }
                if (Input.touches[i].phase.Equals(TouchPhase.Moved))
                {
                    Vector3 Direction = Input.touches[i].position - firstTouch;
                    if (Direction.y > 0)
                    {
                        Jump();
                    }
                }
            }
        }
    }

    private void FixedUpdate()
    {
        if (jumped && jumpCount > 0)
        {
            rigidBody.velocity = Vector2.up * jumpForce;
            jumped = false;
        }
        if (IsGrounded())
        {
            jumpCount = 2;
        }
        if (movingRight)
        {
            rigidBody.transform.position += Vector3.right * playerSpeed * Time.fixedDeltaTime;
            movingRight = false;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (movingLeft)
        {
            rigidBody.transform.position += Vector3.left * playerSpeed * Time.fixedDeltaTime;
            movingLeft = false;
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }

    private bool IsGrounded()
    {
        jumped = false;
        RaycastHit2D Hitinfo = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0f, Vector2.down, 0.1f, groundLayer);
        return Hitinfo.collider != null;
    }
    private void Jump()
    {
        jumped = true;
        jumpCount--;
    }
}
