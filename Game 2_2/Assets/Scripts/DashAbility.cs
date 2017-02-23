using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashAbility : MonoBehaviour {
	public float dash;
	public float dis;
	public float cooldown;
	public float decreaseRate;
	private float current;
	// Use this for initiaization
	void Awake () {
		current = cooldown;
		cooldown = 0;
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.LeftShift) && cooldown == 0) {
			float hor = Input.GetAxis ("Horizontal");
			float ver = Input.GetAxis ("Vertical");
			transform.position = Vector3.Lerp (transform.position, CreateVector(hor, ver), dash);
			cooldown = current;
		}
		if (cooldown <= 0) {
			cooldown = 0;
		} 
		else {
			cooldown -= Time.deltaTime * (decreaseRate / 100);
		}
	}

	void FixedUpdate() {
	}

	Vector3 CreateVector (float hor, float ver) {
		return new Vector3(transform.position.x + hor * dis, transform.position.y, transform.position.z + ver * dis);
	}
}
