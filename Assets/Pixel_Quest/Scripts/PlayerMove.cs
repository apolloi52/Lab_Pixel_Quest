using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rb;
    public float Speed = 5;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if (spriteRenderer = transform.GetChild(0).GetComponent<SpriteRenderer>())
        {
            spriteRenderer = transform.GetChild(0).GetComponent<SpriteRenderer>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2((Speed * xInput), rb.velocity.y);


        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.velocity += new Vector2(rb.velocity.x, -1);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.velocity += new Vector2(rb.velocity.x, 1);
        }
        if (xInput > 0)
        {
            spriteRenderer.flipX = true;
        }
        if (xInput < 0)
        {
            spriteRenderer.flipX = false;
        }
    }
}
   