using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    private Rigidbody2D rb;
    public string NextLevel = "XXXXX";
    public int CoinCounter = 0;
    public int _health = 0;
    private int MaxHealth = 3;
    private PlayerMove playermove;
    private LevelGoal levelGoal;
    public Transform respawnPoint;
    // Start is called before the first frame update
    void Start()
    {
       playermove = GetComponent<PlayerMove>();
        levelGoal = GetComponent<LevelGoal>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Respawn":
                {
                    respawnPoint.position = collision.transform.Find("Point").position;
                    break;
                }
            case "Death":
                {
                    if (_health > 0)
                    {
                        _health -= 1;
                        transform.position = respawnPoint.position;
                        break;
                    }
                    if (_health <= 0)
                    {
                        string thislevel = SceneManager.GetActiveScene().name;
                        SceneManager.LoadScene(thislevel);
                        break;
                    }
                } break;
            case "Finish":
                {
                    string nextLevel = collision.transform.GetComponent<LevelGoal>().NextLevel;
                    break;
                }
            case "Coin":
                {
                    CoinCounter += 1;
                    Destroy (collision.gameObject);
                    break;
                }
            case "Health":
                {
                    if (_health < MaxHealth)
                    {
                        _health += 2;
                    }
                    else
                    {
                      playermove.Speed++;
                    }
                    Destroy(collision.gameObject);
                    break;
                }

        }
    }
}