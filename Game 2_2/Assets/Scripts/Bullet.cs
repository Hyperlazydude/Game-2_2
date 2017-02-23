using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	public float speed;
	public float timeDelete;
	// Use this for initialization
	void Start () {
		//Destroy (gameObject, timeDelete);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.Translate (Vector3.forward * speed * Time.deltaTime);
	}

	void OnCollisionEnter (Collision collision) {
	}
}
