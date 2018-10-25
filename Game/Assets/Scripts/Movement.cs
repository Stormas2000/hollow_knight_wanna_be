using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    private Rigidbody2D rb2d;
    public float speed,jump;
    int grounded;


    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        speed = 10;
        jump = 0;
        grounded = 2;
    }


    void Update()
    {
   
        float h = Input.GetAxis("Horizontal");
        if (grounded != 0)
        {
            jump--;
        }
        
        if (Input.GetButtonDown("Jump") && grounded != 2 )
        {
            jump = 25;
            grounded++;
            
        }
       

        rb2d.velocity = new Vector2(h * speed, jump);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            grounded = 0;
            jump = 0;
        }
    }
}
