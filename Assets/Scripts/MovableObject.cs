using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableObject : MonoBehaviour {
	private Rigidbody2D _rigidbody;

	private void Start() {
		_rigidbody = GetComponent<Rigidbody2D>();
	}

	private void OnCollisionExit2D(Collision2D other) {
		if (other.gameObject.CompareTag("Player")) {
			_rigidbody.velocity *= 0;
		}
	}
}
