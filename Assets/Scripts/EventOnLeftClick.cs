using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(EventActionHelper))]
public class EventOnLeftClick : MonoBehaviour {

	public float shootInterval;
	public UnityEvent events;

	private float _timer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		_timer += Time.deltaTime;

		if (Input.GetMouseButton(0) && _timer > shootInterval) {
			events.Invoke();
			_timer = 0;
		}
	}
}


