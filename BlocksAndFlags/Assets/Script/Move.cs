using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [Range(0.1f, 1)] public float movSpeed;
    [Range(1, 10)] public float maxSpeed;

    // Start is called before the first frame update
    void Start()
    {
        movSpeed = 0.5f;
        maxSpeed = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (GetComponent<Rigidbody2D>().velocity.x < maxSpeed && (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)))
        {
            GetComponent<Rigidbody2D>().velocity += Vector2.right * movSpeed;
        }

        if (GetComponent<Rigidbody2D>().velocity.x > -maxSpeed && (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)))
        {
            GetComponent<Rigidbody2D>().velocity += Vector2.left * movSpeed;
        }
        
    }
}
