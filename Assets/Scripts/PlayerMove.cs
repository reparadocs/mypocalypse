using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MoveTowardsDirection))]
public class PlayerMove : MonoBehaviour {

	public float distanceTolerance = 0.1f;
	public Vector3 destination;
	
	private MoveTowardsDirection _movement;

	// Use this for initialization
	void Start () {
		destination = transform.position;
		_movement = gameObject.GetComponent<MoveTowardsDirection>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(1)) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit objectClicked;
			
			if (Physics.Raycast(ray, out objectClicked) && objectClicked.transform.tag != "Player") {
				destination = objectClicked.point;
				destination.y = transform.position.y;
				_movement.direction = MovementHelper.calculateNormalizedDirection(transform.position, destination);
			}
		}

		if (Vector3.Distance(destination, transform.position) <= distanceTolerance) {
			_movement.direction = Vector3.zero;
		}
	}
}
