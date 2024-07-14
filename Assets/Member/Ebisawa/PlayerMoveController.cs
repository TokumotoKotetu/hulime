using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2d;
    [SerializeField] float speed = 1.0f;
    float x, y;
    public bool _invincible = false;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

    }

    void Update()
    {

        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");

    }
    private void FixedUpdate()
    {

        if (x > 0)
        {
            rb2d.velocity = Vector2.right * speed;
        }
        if(x < 0)
        {
            rb2d.velocity = Vector2.left * speed;
        }
        if(y > 0)
        {
            rb2d.velocity = Vector2.up * speed;
        }
        if(y < 0)
        {
            rb2d.velocity = Vector2.down * speed;
        }
        //if(x == 0 && y == 0)
        //{
        //    rb2d.velocity = Vector2.zero;
        //}

    }
}