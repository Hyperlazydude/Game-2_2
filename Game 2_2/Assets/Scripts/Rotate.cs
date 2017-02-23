using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
	public Transform gameObjectToRotate;

	Vector3 middleOfScreen;
	// Use this for initialization
	void Start () {
		middleOfScreen = new Vector3(Screen.width/2, Screen.height/2, 0f);
	}

	// Update is called once per frame
	void Update () {
		middleOfScreen = new Vector3(Screen.width/2, Screen.height/2, 0f);
		Vector3 camVec = Input.mousePosition - middleOfScreen;
		Vector3 flipped = new Vector3(camVec.x, 0f, camVec.y);
		gameObjectToRotate.LookAt(flipped);
	}
}
