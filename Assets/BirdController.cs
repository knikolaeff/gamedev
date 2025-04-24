using Unity.VisualScripting;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce;

    private bool _hasStarted;
    private float _originalGravityScale;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _originalGravityScale = rb.gravityScale;
        rb.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump")) {
            if (_hasStarted == false)
            {
                rb.gravityScale = _originalGravityScale;
                _hasStarted = true;
            }
            
            rb.linearVelocity = Vector2.zero;
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
