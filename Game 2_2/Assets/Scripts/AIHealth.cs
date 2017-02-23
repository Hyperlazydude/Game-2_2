using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIHealth : MonoBehaviour {
	public int health;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision collision){
		if (collision.gameObject.tag == "Bullet") {
			Destroy (collision.gameObject);
			health--;
			if (health == 0) {
				Destroy (gameObject);
			}
		}
	}
}
