using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(EventActionHelper))]
public class EventOnTimer : MonoBehaviour {

	public float timer = 1;
	public UnityEvent events;
	
	private float _counter = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		_counter += Time.deltaTime;	
		if (_counter >= timer) {
			events.Invoke();
			_counter = 0;
		} 
	}
}
