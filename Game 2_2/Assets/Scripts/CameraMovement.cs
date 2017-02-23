using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
	public Transform target;
	public float positionY;
	private float current;
	// Use this for initialization
	void Start () {
		current = target.position.y;
	}

	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (target.position.x, positionY, target.position.z);
		transform.LookAt (target);
	}
}
