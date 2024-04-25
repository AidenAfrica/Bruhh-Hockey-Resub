using UnityEngine;



public class Bally : MonoBehaviour

{
 public float speed = 1f;
 private Rigidbody2D rb;
 public GameManager GameManager;
 public Vector3 newDirection = new Vector3(0, 0, 0);







    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        

    }
   
    void Start ()
    {
       
    }
    private void StartGame()
    { 
     ResetPosition();
        
    }

    public void ResetPosition()
    {
        rb.position = Vector3.zero;
        rb.velocity = Vector3.zero;

        AddStartingForce();

       
    }

    public void ResetDirection()
    {
        
        if (rb == null)
        {
            rb = GetComponent<Rigidbody2D>();
        }

        
        rb.velocity = newDirection.normalized * speed;
    }


    void OnTriggerEnter2D (Collider2D other)
    {

        if (other.tag == "AiSideR")
        {
            Debug.Log("Direction change");
            //ResetDirection();







        }
        if (other.tag == "PlayerSideR")
        {
            Debug.Log("DirectionChange");
           // ResetDirection();







        }
        
        if (other.tag == "AIGoal")
        {
            Debug.Log("PlayerScores");

            ResetPosition();

           


           
        }
        if (other.tag == "PlayerGoal")
        {
            Debug.Log("AiScores");
            
            ResetPosition();

           

           

        }
    }

    


    //this is bally set with trggers a rigid body and all the code i need for andding forces and basically starting the game

    private void AddStartingForce()
    {

        float x = Random.value < 0.5f ? -1.0f : 1.0f;

        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) :
                                        Random.Range(0.5f, 1.0f);

        Vector2 direction = new Vector2(x, y);

        rb.AddForce(direction * this.speed);

    }

    public void AddForce(Vector2 force)
    {
        rb.AddForce(force);
    }

    public void ResetRound()
    {
       
    }

}



    


