using UnityEngine;

public class HW2PlayerDie : MonoBehaviour
{
    public GameObject EndPanel;
    private string enemy = "Enemy";

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == (enemy))
        {
            EndPanel.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
