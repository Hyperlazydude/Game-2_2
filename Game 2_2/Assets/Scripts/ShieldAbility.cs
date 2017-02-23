using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldAbility : MonoBehaviour {
	public float health;
	public float rate;
	public Shield shield;
	public Transform place;
	public Slider display;


	private float recover;
	private bool shieldOff;
	private Shield newShield;
	// Use this for initialization
	void Awake () {
		display.maxValue = health;
		display.value = health;
	}

	void Start () {
		recover = health;
		shieldOff = true;
	}

	// Update is called once per frame
	void Update () {
		if (!shieldOff) {
			health = newShield.health;
			display.value = health;
		}
		if (Input.GetKeyDown (KeyCode.E)) {
			if (shieldOff && health > recover * 0.25f) {
				shieldOff = false;
				newShield = Instantiate (shield, place.position, place.rotation) as Shield;
				newShield.health = health;
				newShield.transform.parent = transform;
				display.value = health;
			} 
			else if (!shieldOff) {
				display.value = health;
				shieldOff = true;
				health = newShield.health;
				Destroy (newShield.gameObject);
			}

		}
		if (health <= 0 && !shieldOff) {
			Destroy (newShield.gameObject);
			health = 0;
			shieldOff = true;
			display.value = 0;
		}
		if ((health < recover) && (shieldOff == true)) {
			health += Time.deltaTime * (rate / 100);
			display.value = health;
		}
		if (health > recover) {
			health = recover;
			display.value = health;
		}
	}
}
