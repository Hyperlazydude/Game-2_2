using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speed : MonoBehaviour {
	public float speed;
	public float stamina;
	public float rate;
	public Slider display;

	private Movement movement;
	private float original;
	private float recover;
	// Use this for initialization
	void Start () {
		movement = GetComponent<Movement> ();
		original = movement.speed;
		recover = stamina;
		display.maxValue = recover;
		display.value = recover;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey(KeyCode.LeftShift) && stamina > 0) {
			movement.speed = original + speed;
			stamina -= Time.deltaTime;
			display.value = stamina;
		} 
		else {
			movement.speed = original;
			if (stamina >= recover) {
				stamina = recover;
				display.value = stamina;
			} else {
				stamina += Time.deltaTime * (rate / 100);
				display.value = stamina;
			}
		}
	}

	void Update () {
		
	}
}
