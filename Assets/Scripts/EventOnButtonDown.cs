using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(EventActionHelper))]
public class EventOnButtonDown : MonoBehaviour {

	public string button;
	public UnityEvent events;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown(button)) {
			events.Invoke();
		}
	}
}
