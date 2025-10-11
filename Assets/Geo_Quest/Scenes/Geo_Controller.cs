using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Geo_Controller : MonoBehaviour
{
    private Rigidbody2D rb;
    public float Speed = 5;
    public string nextLevel = "Geo_Quest_Scene_2";
    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity += new Vector2(-1, rb.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity += new Vector2(1, rb.velocity.y);
        }*/

        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2((Speed*xInput), rb.velocity.y);

       
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.velocity += new Vector2(rb.velocity.x, -1);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.velocity += new Vector2(rb.velocity.x, 1);
        }
    }
private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Death":
                {
                    string thislevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thislevel);
                        break;
                }
            case "Finish1":
                {
                    SceneManager.LoadScene("Geo_Quest_Scene_2");
                    break;
                }
            case "Finish2":
                {
                    SceneManager.LoadScene("Geo_Quest_Scene_3");
                    break;
                }

        }
    }
}
