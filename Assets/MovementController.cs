using UnityEngine;

public class MovementController : MonoBehaviour
{
    
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
    }
}
