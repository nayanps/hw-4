using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    Rigidbody2D body;

    float horizontal;
    float vertical;

    public float Speed = 1.0f;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector2(horizontal * Speed, vertical * Speed);
    }
}
