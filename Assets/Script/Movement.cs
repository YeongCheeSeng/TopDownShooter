using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D _rigidbody2D;
    Collider2D _collider2D;

    public float Speed = 10;
    protected const float m_MovementSmoothing = 0.05f;

    Vector2 m_Velocity = Vector2.zero;
    protected Vector2 _inputDirection;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _collider2D = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleInput();
        HandleMovement();

        if (Input.GetKey(KeyCode.W))
            _inputDirection = Vector2.up;
        else if (Input.GetKey(KeyCode.S))
            _inputDirection = Vector2.down;
        else if (Input.GetKey(KeyCode.A))
            _inputDirection = Vector2.left;
        else if (Input.GetKey(KeyCode.D))
            _inputDirection = Vector2.right;
        else 
            _inputDirection = Vector2.zero;

        /*
        if (Input.GetKey(KeyCode.W))
        {
            _rigidbody2D.AddForce(Vector2.up * (Speed * Time.deltaTime));
        }
        else if (Input.GetKey(KeyCode.S))
        {
            _rigidbody2D.AddForce(Vector2.down * (Speed * Time.deltaTime));
        }
        else if (Input.GetKey(KeyCode.A))
        {
            _rigidbody2D.AddForce(Vector2.left * (Speed * Time.deltaTime));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            _rigidbody2D.AddForce(Vector2.right * (Speed * Time.deltaTime));
        }
        else
        {
            _rigidbody2D.velocity = Vector2.zero;
        }
        */

    }

    protected virtual void HandleMovement()
    {
        if (_collider2D == null || _rigidbody2D == null)
            return;

        Vector2 targetVelocity = Vector2.zero;
        targetVelocity = new Vector2(x: _inputDirection.x * Speed, y: _inputDirection.y * Speed);

        _rigidbody2D.velocity = Vector2.SmoothDamp(_rigidbody2D.velocity, targetVelocity, ref m_Velocity, m_MovementSmoothing);
    }

    protected virtual void HandleInput()
    {
        
    }
}
