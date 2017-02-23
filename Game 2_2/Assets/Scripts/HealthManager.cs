using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthManager : MonoBehaviour {
	public UnityEvent onBulletHit;

	public int health;

	private Animator anim;
	public bool isVulnerable;
	// Use this for initialization

	void Awake () {
		isVulnerable = true;
		anim = GetComponent<Animator> ();
	}

	void Start () {
		
	}
	private void MakeVulnerable (){
		anim.SetTrigger ("Vulnerable");
		isVulnerable = true;

	}

	public void MakeInvulnerable () {
		anim.SetTrigger ("isVulnerable");
		isVulnerable = false;
		Invoke ("MakeVulnerable", 2.0f);
	}
	// Update is called once per frame
	void Update () {
	}
}
