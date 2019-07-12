﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAssist : MonoBehaviour
{
    [Range(1, 3)] public float fallMultiplier;

    Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
    }
}
