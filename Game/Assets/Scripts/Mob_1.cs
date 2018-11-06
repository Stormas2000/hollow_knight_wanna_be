using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob_1 : MonoBehaviour {
    bool offensivemode;
    private Rigidbody2D rigi_mob1;
    public float speed, jump,health;
    public int attack_damage;
    Player_manegement damage_player;
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
    public void damage_mob()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Weapon")
        {
            damage_player.damage_manager(attack_damage);
        }
    }
}
