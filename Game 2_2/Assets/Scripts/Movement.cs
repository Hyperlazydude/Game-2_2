using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	public float speed;
	private Rigidbody player;
	public float timeJump;
	private float recover;
	// Use this for initialization
	void Awake () {
		player = GetComponent<Rigidbody> ();
		recover = timeJump;
		timeJump = 0;
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void FixedUpdate () {
		float hor = Input.GetAxis ("Horizontal");
		float ver = Input.GetAxis ("Vertical");
		float jump = 0;
		if (!Input.GetKey(KeyCode.LeftShift)){
			jump = Input.GetAxis ("Jump");
			timeJump = recover;
		}
		timeJump -= Time.deltaTime;
		player.MovePosition (transform.position + new Vector3 (hor, jump, ver) * speed * Time.deltaTime);
	}
}
