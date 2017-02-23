using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	public float speed;
	private Rigidbody player;
	// Use this for initialization
	void Awake () {
		player = GetComponent<Rigidbody> ();
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void FixedUpdate () {
		float hor = Input.GetAxis ("Horizontal");
		float ver = Input.GetAxis ("Vertical");
		float jump = Input.GetAxis ("Jump");
		player.MovePosition (transform.position + new Vector3 (hor, jump, ver) * speed * Time.deltaTime);
	}
}
