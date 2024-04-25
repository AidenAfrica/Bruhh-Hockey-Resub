using UnityEngine;

public class PlayerSideR : MonoBehaviour
{
    public Vector2 newDirection = new Vector2(-1, 1); 

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Bally"))
        {
           
            Rigidbody2D rb = other.GetComponent<Rigidbody2D>();

           
            rb.velocity = newDirection.normalized * rb.velocity.magnitude;
        }
    }
}