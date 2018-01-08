using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MoveTowardsDirection))]
public class EnemyIntelligence : MonoBehaviour {

	private GameObject _target;
	private MoveTowardsDirection _movement;

	// Use this for initialization
	void Start () {
		GameObject[] targets = GameObject.FindGameObjectsWithTag("Player");
		if (targets.Length > 0) {
			_target = targets[0];
		}
		_movement = gameObject.GetComponent<MoveTowardsDirection>();
	}
	
	// Update is called once per frame
	void Update () {
		_movement.direction = MovementHelper.calculateNormalizedDirection(transform.position, _target.transform.position);
	}
}
