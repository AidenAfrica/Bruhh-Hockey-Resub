using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinusPointsScript : MonoBehaviour
{

    Rigidbody2D rb;
    bool player;

    int playerScore = 0;
    int oppScore = 0;

    int playerTouches = 0;
    int oppTouches = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            //Change of direction
            Debug.Log("Pressed");
            rb.velocity = rb.transform.up * rb.velocity.magnitude;

        }

        if (Input.GetKey(KeyCode.B))
        {

            //portals
            transform.position = new Vector2(5, transform.position.y);

        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            player = true;

            playerTouches++;
            if (playerTouches > 1 && playerScore < 0)
            {
                playerScore--;
                playerTouches = 0;

            }

        }
        else if (collision.transform.tag == "Opp")
        {
            player = false;

            oppTouches++;
            if (oppTouches > 1 && playerScore < 0)
            {
                oppScore--;
                oppTouches = 0;

            }
        }


        //for extra points
        if (player == true && collision.gameObject.tag == "Point")
        {
            playerScore++;
        }

        if (player == false && collision.gameObject.tag == "Point")
        {
            oppScore++;
        }

    }



}