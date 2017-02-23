using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindPlayer : MonoBehaviour {
	public Transform player;
	public GameObject gameOver;
	public GameObject Win;
	public GameObject ui;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find("Player") == null) {
			gameOver.SetActive (true);
			ui.SetActive (true);
		}
		if (player.position.z > 184) {
			Win.SetActive (true);
			ui.SetActive (true);
		}
	}
}
