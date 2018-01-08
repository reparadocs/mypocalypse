using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventActionHelper : MonoBehaviour {

	public void CreatePrefab(GameObject prefab) {
		Object.Instantiate(prefab, transform.position, Quaternion.identity);
	}

	public void DestroyObject(GameObject target) {
		Object.Destroy(target);
	}

	public void StopMovement(GameObject target) {
		MoveTowardsDirection movement = target.GetComponent<MoveTowardsDirection>();
		if (movement) {
			movement.direction = Vector3.zero;
		} else {
			Debug.LogError("Target must have component MoveTowardsDirection to Stop Movement", target);
		}
	}
}
