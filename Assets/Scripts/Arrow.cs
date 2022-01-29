using System;
using UnityEditor;
using UnityEngine;

public class Arrow : MonoBehaviour {

	public float lifetime;
	
	public float arrowSpeed;
	internal Vector2 Velocity;

	private int _canMove = 1;

	private void Update() {
		if (lifetime <= 0) Destroy(gameObject);
	}

	private void FixedUpdate() {
		transform.Translate(Velocity * arrowSpeed * Time.deltaTime * _canMove);
		lifetime -= Time.deltaTime;
	}

	private void OnTriggerEnter2D(Collider2D col) {
		if (!col.CompareTag("Player")) {
			_canMove = 0;
			
			if (!col.CompareTag("Arrow"))
				transform.SetParent(col.transform);
		}
		else {
			StartCoroutine(FindObjectOfType<GameManager>().DefeatSequence());
		}
	}
}