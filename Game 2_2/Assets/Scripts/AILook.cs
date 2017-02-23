using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AILook : MonoBehaviour {
	public Transform target;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 place = new Vector3 (target.position.x, 0, target.position.y);
		transform.LookAt (place);
	}
}
