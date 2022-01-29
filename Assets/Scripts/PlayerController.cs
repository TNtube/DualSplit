using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;
	
	private float _axisX;
	private float _axisY;

	public bool mirroredPlayer;

	[SerializeField]
	private bool _isMirror;

	// Update is called once per frame
    void Update() {
		_axisX = Input.GetAxis("Horizontal");
		_axisY = Input.GetAxis("Vertical");

		if (Input.GetButtonDown("Jump")) {
			_isMirror = !_isMirror;
		}
	}

	private void FixedUpdate() {
		GetComponent<Rigidbody2D>().velocity = 
			new Vector2(_axisX * speed * Time.deltaTime * (_isMirror && mirroredPlayer ? -1f : 1f), 
				_axisY * speed * Time.deltaTime);
	}
}
