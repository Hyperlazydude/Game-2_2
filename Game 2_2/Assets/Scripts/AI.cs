using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour {
	public Transform player;
	public float targetDist;
	public float timeAtt;
	public float nextAtt;
	public float timeDelete;
	public Bullet bullet;
	public float speed;
	public Transform point1;
	public Transform point2;
	public Transform point3;
	public Transform point4;


	NavMeshAgent agent;
	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent> ();
	}

	// Update is called once per frame
	void Update () {
		agent.SetDestination (player.position);
		if (Time.time > nextAtt) {
			float sqrDist = (player.position - transform.position).sqrMagnitude;
			if (sqrDist < Mathf.Pow (targetDist, 2)) {
				nextAtt = Time.time + timeAtt;
				Bullet newBullet = Instantiate (bullet, point1.position, point1.rotation) as Bullet;
				newBullet.speed = speed;
				Destroy (newBullet.gameObject, timeDelete);
				Bullet newBullet2 = Instantiate (bullet, point2.position, point2.rotation) as Bullet;
				newBullet2.speed = speed;
				Destroy (newBullet2.gameObject, timeDelete);
				Bullet newBullet3 = Instantiate (bullet, point3.position, point3.rotation) as Bullet;
				newBullet3.speed = speed;
				Destroy (newBullet3.gameObject, timeDelete);
				Bullet newBullet4 = Instantiate (bullet, point4.position, point4.rotation) as Bullet;
				newBullet4.speed = speed;
				Destroy (newBullet4.gameObject, timeDelete);
			}
		}
	}
}
