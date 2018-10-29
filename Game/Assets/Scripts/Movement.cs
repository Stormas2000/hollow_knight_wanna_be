using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    private Rigidbody2D rb2d;
    private float speed,jump,h;
    bool grounded;
    int jumpCount;
    public LayerMask groundLayer;
   

    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        speed = 10;
    }


    void FixedUpdate()
    {
       
        rb2d.velocity = new Vector2(h * speed, jump);

    }

    void Update()
    {
        GroundedUpdater();

        if (grounded)
        {
            jumpCount = 0;
            jump = 0;
        }
        else
        {
            jump-=0.2f;
        }


        if (Input.GetButtonDown("Jump") && jumpCount != 2)
        {
            jump = 15;
            jumpCount++;
        }


        transform.rotation = Quaternion.identity;
        h = Input.GetAxisRaw("Horizontal");
    }

    void GroundedUpdater()
    {
        grounded = false;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down , 0.75f, groundLayer);
        
        if (hit.collider != null)
        {
            grounded = true;
        }
        
        RaycastHit2D hit2 = Physics2D.Raycast(transform.position, Vector2.up, 0.9f, groundLayer);

        if (hit2.collider != null)
        {
            jump -= 0.4f;
        }

    }

}
