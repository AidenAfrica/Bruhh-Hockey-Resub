using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceScript : MonoBehaviour
{
   public float bounceStrength;



    private void OnCollisionEnter2D(Collision2D collision)
    {
        Bally ball = collision.gameObject.GetComponent<Bally>();


        if (ball != null)
        {
            Vector2 normal = collision.GetContact(0).normal;
            ball.AddForce(-normal * this.bounceStrength);
        }

    }










}
