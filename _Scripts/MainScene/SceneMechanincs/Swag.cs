using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swag : MonoBehaviour {

    private GameController gC;

	void Start ()
    {
        gC = FindObjectOfType<GameController>();
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
            gC.SwagTaken();
    }

}
