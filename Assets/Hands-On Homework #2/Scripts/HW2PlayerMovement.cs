using UnityEngine;

public class HW2PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbod2D;

    private float _XSpeed;
    private float _YSpeed;

    public float _speed = 3;

    private void Start()
    {
        _rigidbod2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _XSpeed = Input.GetAxis("Horizontal");
        _YSpeed = Input.GetAxis("Vertical");

        _rigidbod2D.velocity = new Vector2(_XSpeed, _YSpeed) * _speed;
    }
}
