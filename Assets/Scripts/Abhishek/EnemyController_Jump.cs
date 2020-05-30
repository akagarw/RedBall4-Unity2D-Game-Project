using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController_Jump : MonoBehaviour
{
    public float JumpSpeed = 2f;
    private bool isGround;
    private Rigidbody2D rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        isGround = true;
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // FixedUpdate is called in 0.2 seconds
    void FixedUpdate()
    {
        if(isGround == true)
        {
            rigidBody.velocity = new Vector2(0, JumpSpeed);
            isGround = false;
        }
    }

    private void OnTriggerStay2D(Collider2D other) {
        if (other.tag == "GroundCheck")
        {
            isGround = true;
        }
    }
}
