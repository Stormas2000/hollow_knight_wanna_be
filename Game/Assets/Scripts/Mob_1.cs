using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob_1 : MonoBehaviour {
    bool offensivemode;
    private Rigidbody2D rigi_mob1;
    public float speed, jump,health;
    public int attack_damage;
    // Use this for initialization
    void Start () {
        health = 100;
        attack_damage = 10;
	}
	
	// Update is called once per frame
    private void FixedUpdate()
    {
        if (offensivemode == true)
        {
            speed = 10;
            offensivemode = false;
        }
        rigi_mob1.velocity = new Vector2(speed, jump);
        jump = 0;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            offensivemode = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag != "Player" || collision.gameObject.tag != "Weapon")
        {
            jump = 25;
        }
        if(collision.gameObject.tag != "Weapon")
        {
            //chamar a variavel do player q e responsavel pelo damage
        }
    }
}
