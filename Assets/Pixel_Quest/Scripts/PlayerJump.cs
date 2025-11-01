using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 10f;
    private Rigidbody2D rb;

    public float CapsuleHeight = 0.2f;
    public float CapsuleRadius = 0.05f;
    private bool groundcheck;
    public Transform feetCollider;
    public LayerMask groundLayer;

    public float fallforce = 1.5f;
    Vector2 gravityvector;

    private bool waterCheck = false;
    private string waterTag = "Water"; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gravityvector = new Vector2 (0, Physics2D.gravity.y);
    }

    // Update is called once per frame
    void Update()
    {
        groundcheck = (Physics2D.OverlapCapsule(feetCollider.position, new Vector2(CapsuleHeight, CapsuleRadius), CapsuleDirection2D.Horizontal, 0, groundLayer));

        if ((groundcheck || waterCheck) && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        if (rb.velocity.y < 0 && !waterCheck)
        {
            rb.velocity += gravityvector * fallforce * 1/2*Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag(waterTag))
        {
            waterCheck = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(waterTag))
        {
            waterCheck = false;
        }
    }
}
