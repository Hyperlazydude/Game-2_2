using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour {
	public Bullet bullet;
	public float speed;
	public float timeDelete;
	public float timeBetweenShots;
	private float current;

	public Transform point;
	// Use this for initialization
	void Start () {
		current = timeBetweenShots;
		timeBetweenShots = 0;
	}
	
	// Update is called once per frame
	void Update () {
		timeBetweenShots -= Time.deltaTime;
		if (timeBetweenShots <= 0) {
			timeBetweenShots = current;
			Bullet newBullet = Instantiate (bullet, point.position, point.rotation) as Bullet;
			newBullet.speed = speed;
			Destroy (newBullet.gameObject, timeDelete);
		}
	}
}
