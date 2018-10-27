using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob_controller : MonoBehaviour {
    bool offensivemode;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
    private void FixedUpdate()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == "Player")
        {
            offensivemode = false;
        }
    }
}
