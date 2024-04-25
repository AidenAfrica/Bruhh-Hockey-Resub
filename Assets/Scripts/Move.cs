using UnityEngine;

public class Move:MonoBehaviour
{
    public float speed = 1f;

    protected Rigidbody2D rb;

    

    

     private void  Awake()
    { 
      rb = GetComponent<Rigidbody2D>();
    }
    
}


//i have a main move script which feeds variables between the player and Ai paddles.
// it 