using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_manegement : MonoBehaviour {
    public float Player_hp;
    public int Player_base_damage, monster_damage, armor,level,experience, experience_level_up;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void Level_manager()
    {
        if (experience == 100)
        {
            level++;
            //aumentar a experiencia necessaria para dar level up
        }
    }
    public void damage_manager(int damage_taken)
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag =="Monster")
        {
            //chamar as variaveis
        }
    }
}
