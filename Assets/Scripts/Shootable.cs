using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootable : MonoBehaviour {

	public int health;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		Destroy(other.gameObject);
		health -= 1;
		if (health <= 0) {
			Destroy(gameObject);
		}
	}
}
