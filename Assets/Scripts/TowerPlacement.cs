using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlacement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Vector3 pos = transform.position;
		pos.y = 0.3f;
		transform.position = pos;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
