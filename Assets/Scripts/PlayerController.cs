using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float maxSpeed = 20f;
    public float jumpForce = 1000f;
    
    private float _moveX;
    private Rigidbody2D _rigidBody2D;
    private bool faceRight = true;
    
    

    private void FixedUpdate()
    {
        _moveX = Input.GetAxis("Horizontal");
    }

    // Start is called before the first frame update
    private void Start()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _rigidBody2D.AddForce(Vector2.up * jumpForce);
        }
        _rigidBody2D.velocity = new Vector2(_moveX * maxSpeed, _rigidBody2D.velocity.y);

        if (_moveX > 0 && !faceRight)
        {
            Flip();
        }
        else if (_moveX < 0 && faceRight)
        {
            Flip();
        }
    }

    private void Flip()
    {
        faceRight = !faceRight;

        var theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
