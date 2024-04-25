using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AIMove : Move
{
    public Rigidbody2D ball;
  private void FixedUpdate()
   {
        if (this.ball.velocity.x > 0.0f)
        {
            if (this.ball.position.y > this.transform.position.y)
            {
                rb.AddForce(Vector2.up * this.speed );
            }
            else if (this.ball.position.y < this.transform.position.y)
            {
                rb.AddForce(Vector2.down * this.speed);
            }
            else if (this.ball.velocity.y > this.transform.position.y)
            {

            }
            else
            {
              if (this.transform.position.y + this.transform.position.y > 0.0f)
                {
                    rb.AddForce(Vector2.down * this.speed); rb.AddForce(Vector2.left *this.speed);
                }
              else if (this.transform.position.y + this.transform.position.y < 0.0f)
                {
                    rb.AddForce(Vector2.up * this.speed); 
                }
            }
        }

   }


}



//Sooo i have a simple Ai that moves on the Y axis only
//i used if stameemnts  which tracks the position of the ball
//it references the balls rigid body, i coded it that so if ball is above the Ai pddle it moves downward
//and if the ball is above it it moves upward on the y axis