using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D PlayerBodyPhysics;
    private float playerSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        PlayerBodyPhysics = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
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



        if (Input.GetKey(KeyCode.Space) == true)
            PlayerBodyPhysics.velocity = new Vector2(PlayerBodyPhysics.velocity.x, playerSpeed);
    }
}
