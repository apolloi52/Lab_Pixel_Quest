using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    private Rigidbody2D rb;
    public string NextLevel = "XXXXX";
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
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