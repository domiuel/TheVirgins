using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D PlayerBodyPhysics;
    [SerializeField] public float jumpForce;
    public float playerSpeed = 5;

    public float countDown = 1f;
    public Camera Cam;

    public LayerMask whatisGround;
    public Transform feetPos;
    private bool isGrounded;
    private float checkRadius;

    private bool isJumping;

    // Start is called before the first frame update
    public void Start()
    {
        PlayerBodyPhysics = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    public void Update()
    {
<<<<<<< HEAD
        float horizontalinput = Input.GetAxis("Horizontal");
        PlayerBodyPhysics.velocity = new Vector2(horizontalinput * playerSpeed, PlayerBodyPhysics.velocity.y);
=======
        float horizontalInput = Input.GetAxis("Horizontal");
        PlayerBodyPhysics.velocity = new Vector2(horizontalInput * playerSpeed, PlayerBodyPhysics.velocity.y);

        // detection for if the player moves right/left (chronological order)
       if (horizontalInput > 0.01f)
        {
            transform.localScale = new Vector2(1, transform.localScale.y);
        }
       else if (horizontalInput < -0.01f)
       {
            transform.localScale = new Vector2(-1, transform.localScale.y);
        }


>>>>>>> 6a1c20be50035a3572778ccb4be2e15b24427187

        if (horizontalinput > 0.01f)
            transform.localScale = new Vector2(transform.localScale.y * 1, transform.localScale.y);
        if (horizontalinput < -0.01f)
            transform.localScale = new Vector2(transform.localScale.y * -1, transform.localScale.y);

        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatisGround);
        if (isGrounded == true && Input.GetKey(KeyCode.Space) && isJumping == false)
        {
            isJumping = true;
            PlayerBodyPhysics.velocity = Vector2.up * jumpForce;
        }
        else
        {
                isJumping = false;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            playerSpeed += 2;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            playerSpeed -= 2;
        }
    }
}
