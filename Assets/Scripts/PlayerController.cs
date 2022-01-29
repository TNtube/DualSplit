using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;
	
	private float _axisX;
	private float _axisY;

	// Update is called once per frame
    void Update() {
		_axisX = Input.GetAxis("Horizontal");
		_axisY = Input.GetAxis("Vertical");
	}

	private void FixedUpdate() {
		GetComponent<Rigidbody2D>().velocity = new Vector2(_axisX * speed * Time.deltaTime, _axisY * speed * Time.deltaTime);
	}
}
