using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsDirection : MonoBehaviour {

	public float speed = 6.0f;
	public Vector3 direction;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += direction * speed * Time.deltaTime;
	}
}
