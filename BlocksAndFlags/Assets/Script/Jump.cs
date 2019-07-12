using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [Range(1, 10)] public float jumpHeight;
    private bool canJump;


    // Start is called before the first frame update
    void Start()
    {
        jumpHeight = 8;
        canJump = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(canJump && (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)))
        {
            GetComponent<Rigidbody2D>().velocity += Vector2.up * jumpHeight;
            canJump = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.gameObject.layer == 8)
        {
            canJump = true;
        }
    }
}
