using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D _rigidbody2D;
    Collider2D _collider2D;
    public int Speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _collider2D = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _rigidbody2D.AddForce(Vector2.up * (Speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.S))
        {
            _rigidbody2D.AddForce(Vector2.down * (Speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.A))
        {
            _rigidbody2D.AddForce(Vector2.left * (Speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.D))
        {
            _rigidbody2D.AddForce(Vector2.right * (Speed * Time.deltaTime));
        }
    }
}
