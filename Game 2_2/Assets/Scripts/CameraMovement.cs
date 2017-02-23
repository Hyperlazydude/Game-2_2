using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
	public Transform target;
	public float positionY;
	private float current;
	public float dist;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		positionY = target.position.y + dist;
		transform.position = new Vector3 (target.position.x, positionY, target.position.z);
		transform.LookAt (target);
	}
}
