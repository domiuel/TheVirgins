using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    [SerializeField] private float bulletSpeed = 10;
    public Transform GunPos;
    public GameObject GunBody;

    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) == true)
        {
            GameObject bullet = Instantiate(GunBody, GunPos.position, GunPos.rotation);
            Rigidbody2D BulletRigidBody = bullet.GetComponent<Rigidbody2D>();

            BulletRigidBody.velocity = transform.right * Player.transform.localScale.x * bulletSpeed;
        }
    }
}
