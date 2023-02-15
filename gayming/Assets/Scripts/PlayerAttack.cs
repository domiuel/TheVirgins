using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] public float attackCooldown;
    public float cooldownTimer = Mathf.Infinity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && cooldownTimer > attackCooldown)
            attack();

        cooldownTimer += Time.deltaTime;
    }

    private void attack()
    {
        cooldownTimer = 0;
    }
}
