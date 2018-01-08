using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementHelper : MonoBehaviour {

	public static Vector3 calculateNormalizedDirection(Vector3 from, Vector3 to) {
		Vector3 direction = to - from;
		direction.y = 0;
		direction.Normalize();
		return direction;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
