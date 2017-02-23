using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableObject : MonoBehaviour {
	public Transform player;
	public GameObject other;
	public GameObject movements;
	public GameObject shield;
	public GameObject shieldSlide;
	public GameObject wait;
	public GameObject shoot;
	public GameObject sprint;
	public GameObject sprintBar;
	public int counter = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (player.position.z > 0) {
			movements.SetActive (false);
		} else {
			movements.SetActive (true);
		}
		if (player.position.z > 35 && counter == 0) {
			other.GetComponent<ShieldAbility> ().enabled = true;
			shield.SetActive (true);
			shieldSlide.SetActive (true);
			counter++;
			StartCoroutine (shieldActive ());
		}
		if (player.position.z > 67 && counter == 1) {
			wait.SetActive (true);
			counter++;
			StartCoroutine (waitActive ());
		}
		if (player.position.z > 102 && counter == 2) {
			other.GetComponentInChildren<FireAbility> ().enabled = true;
			shoot.SetActive (true);
			counter++;
			StartCoroutine (shootActive ());
		}
		if (player.position.z > 147 && counter == 3) {
			other.GetComponent<Speed> ().enabled = true;
			sprint.SetActive (true);
			sprintBar.SetActive (true);
			counter++;
			StartCoroutine (sprintActive ());
		}
	}
	IEnumerator shieldActive () {
		yield return new WaitForSeconds (3);
		shield.SetActive (false);
	}	
	IEnumerator waitActive () {
		yield return new WaitForSeconds (5);
		wait.SetActive (false);
	}
	IEnumerator shootActive () {
		yield return new WaitForSeconds (3);
		shoot.SetActive (false);
	}
	IEnumerator sprintActive () {
		yield return new WaitForSeconds (3);
		sprint.SetActive (false);
	}
}
