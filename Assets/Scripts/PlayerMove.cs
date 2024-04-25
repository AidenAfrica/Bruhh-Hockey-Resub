
using UnityEngine;

public class PlayerMove : Move{
    private Vector2 direction;
    [SerializeField]
    private float minX = 1f;

    [SerializeField]    
    private float minY = 1f;

    [SerializeField]
    private float maxX = 1f;

    [SerializeField]
    private float maxY = 1f;






    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    


    }

    private void Update()
    {

       
        if (Input.GetKey(KeyCode.W))
            {
                direction = Vector2.up;
            }
        else if (Input.GetKeyUp(KeyCode.W))
            {
                direction = Vector2.zero;
            }




        if (Input.GetKey(KeyCode.S))
            {
                direction = Vector2.down;
            }
        else if (Input.GetKeyUp(KeyCode.S))
            {
                direction = Vector2.zero;
            }


        if (Input.GetKey(KeyCode.A))
            {
                direction = Vector2.left;
            }
        else if (Input.GetKeyUp(KeyCode.A))
            { 
            direction = Vector2.zero;
            }



        if (Input.GetKey(KeyCode.D))
            {
            direction = Vector2.right;
            }
        else if (Input.GetKeyUp(KeyCode.D))
            {
            direction = Vector2.zero;
            }
    }


    private void FixedUpdate()
    {
       if (direction.sqrMagnitude != 0) 
        
       if (direction != Vector2.zero)
        {
            rb.AddForce(direction * speed);
            ClampPosition();
           
        }

    

    }

    private void ClampPosition()
    {

        
        Vector3 clampedPosition = transform.position;
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, minX, maxX);
        clampedPosition.y = Mathf.Clamp(clampedPosition.y, minY, maxY);
        transform.position =clampedPosition;


        
    }





}



// i didnt use  mouse drag because mouse drag because this was more easier and made the game feel more fun in my opinion
// i was going to implement my clamp heere but it was easier to use exclusion layers as it was so much easier
// i used a fixed update to keep the games equal in terms of framerate complications. 