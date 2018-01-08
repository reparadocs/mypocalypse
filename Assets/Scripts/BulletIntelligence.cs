using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MoveTowardsDirection))]
public class BulletIntelligence : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit objectClicked;
		
		if (Physics.Raycast(ray, out objectClicked) && objectClicked.transform.tag != "Player") {
			Vector3 target = objectClicked.transform.tag == "Ground" ? objectClicked.point : objectClicked.transform.position;
			MoveTowardsDirection movement = gameObject.GetComponent<MoveTowardsDirection>();
			movement.direction = MovementHelper.calculateNormalizedDirection(transform.position, target);
		}
	}
	
	// Update is called once per frame
	void Update () {
	}
}
