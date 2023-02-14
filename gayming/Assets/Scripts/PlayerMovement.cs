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
        PlayerBodyPhysics.velocity = new Vector2(Input.GetAxis("Horizontal") * playerSpeed, PlayerBodyPhysics.velocity.y);

        if (Input.GetKey(KeyCode.Space) == true)
            PlayerBodyPhysics.velocity = new Vector2(PlayerBodyPhysics.velocity.x, playerSpeed);
    }
}
