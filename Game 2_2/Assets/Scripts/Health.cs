using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {
	public Sprite fullHealth;
	public Sprite halfHealth;
	public Sprite emptyHealth;
	Image[] images;
	// Use this for initialization
	void Awake () {
		images = GetComponentsInChildren<Image> ();
		System.Array.Reverse (images);
	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void RemoveHealth() {
		foreach (Image child in images) {
			if (child.sprite == fullHealth) {
				child.sprite = halfHealth;
				break;
			} else if (child.sprite == halfHealth) {
				child.sprite = emptyHealth;
				break;
			}
		}
	}
}
