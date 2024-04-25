using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiSideR : MonoBehaviour
{
    public Vector2 newDirection = new Vector2(-8, 1); 

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Bally"))
        {
           
            Rigidbody2D rb = other.GetComponent<Rigidbody2D>();

            
            rb.velocity = newDirection.normalized * rb.velocity.magnitude;
        }
    }
}