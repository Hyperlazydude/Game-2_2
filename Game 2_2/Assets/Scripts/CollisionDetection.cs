using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter (Collision collision) {
		foreach (ContactPoint c in collision.contacts) {
			if (c.thisCollider.tag == "shield" && collision.gameObject.tag == "AI Bullet") {
				Shield shield = c.thisCollider.gameObject.GetComponent<Shield>();
				shield.health--;
				Destroy (collision.gameObject);
			}
			if (c.thisCollider.tag == "player" && collision.gameObject.tag == "AI Bullet") {
				HealthManager health = gameObject.GetComponent<HealthManager> ();
				Destroy (collision.gameObject);
				if (health.isVulnerable == true) {
					health.health--;
					if (health.health == 0) {
						Destroy (gameObject);
					}
					health.MakeInvulnerable ();
					health.onBulletHit.Invoke ();
				}
			}
			if (c.thisCollider.tag == "player" && collision.gameObject.tag == "AI") {
				HealthManager health = gameObject.GetComponent<HealthManager> ();
				if (health.isVulnerable == true) {
					health.health--;
					if (health.health == 0) {
						Destroy (gameObject);
					}
					health.MakeInvulnerable ();
					health.onBulletHit.Invoke ();
				}
			}
		}
	}
}
