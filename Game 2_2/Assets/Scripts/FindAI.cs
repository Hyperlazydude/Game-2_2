using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindAI : MonoBehaviour {
	public GameObject wall;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.FindGameObjectWithTag ("AI") == null) {
			Destroy (wall.gameObject);
		}
	}
}
