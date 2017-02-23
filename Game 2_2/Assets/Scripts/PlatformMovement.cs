using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour {
	public Vector3 current;
	public Vector3 dest;
	public float speed;
	public Vector3 move;
	// Use this for initialization
	void Awake () {
		current = transform.position;
		move = dest;
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards (transform.position, move, speed * Time.deltaTime);
		if (transform.position == move) {
			move = current;
		}
		if (transform.position == current) {
			move = dest;
		}
	}
}
