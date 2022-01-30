using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowShooter : MonoBehaviour {

	public GameObject arrow;

	public float frequency;

	public Vector2 velocity;

	public Sprite[] arrowShooterSprites;
	private float _elapsedTime;
	
	private void Start() {
		int index = (int)velocity.y == -1 ? 0 : 1;
		GetComponent<SpriteRenderer>().sprite = arrowShooterSprites[index];
	}

	// Update is called once per frame
    void Update() {

		if (_elapsedTime >= frequency) {
			var t = transform;
			var localScale = t.localScale;
			var position = t.position + new Vector3(velocity.x * localScale.x * 0.6f, velocity.y * localScale.y * 0.6f , 0);
			var go = Instantiate(arrow, position, Quaternion.identity);
			go.GetComponent<Arrow>().Velocity = velocity;
			_elapsedTime = 0f;
		}

		_elapsedTime += Time.deltaTime;
	}
}
