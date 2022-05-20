using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 100;
    private Rigidbody2D rb2d;
    float flipSpeed;
    // flip
    bool flipRight = true;
    // jump
    public float jumpForce;
    public Transform groundCheck;
    public LayerMask groundLayer;
    bool isGround;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        flipRight = true;
    }

    void FixedUpdate()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        rb2d.velocity = new Vector2(moveSpeed * moveX * Time.fixedDeltaTime, rb2d.velocity.y);
        


        isGround = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGround)
            {
                jump();
            }

        }

        if (moveX < 0 && flipRight)
        {
          
            flip();
            rb2d.velocity = new Vector2(-flipSpeed,rb2d.velocity.y);
        }


        if (moveX > 0 && !flipRight)
        {
           
            flip();
            rb2d.velocity = new Vector2(flipSpeed, rb2d.velocity.y);
        }     

    }  // update class


    private void flip()
    {
        flipRight = !flipRight;
        transform.Rotate(0f, 180f, 0f);
    }

    public void jump()
    {
        rb2d.velocity = Vector2.up * jumpForce;
    }




} // calss line
