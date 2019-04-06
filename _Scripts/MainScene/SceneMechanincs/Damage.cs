using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {

    private GameController gC;

	// Use this for initialization
	void Start () {

        gC = FindObjectOfType<GameController>();
		
	}
	
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
            gC.Damage();
    }
}
