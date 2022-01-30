using System;
using UnityEditor;
using UnityEngine;

public class Arrow : MonoBehaviour {

	public float lifetime;
	
	public float arrowSpeed;
	public Sprite[] arrowSprites;
	
	internal Vector2 Velocity;

	private int _canMove = 1;

	private Sprite arrowSprite;

	private void Start() {
		switch (Velocity.x) {
			case 1 :
				arrowSprite = arrowSprites[0];
				break;
			case -1:
				arrowSprite = arrowSprites[1];
				break;
			default:
				switch (Velocity.y) {
					case 1 :
						arrowSprite = arrowSprites[2];
						break;
					case -1:
						arrowSprite = arrowSprites[3];
						break;
					default:
						print("not a good dir");
						break;
				}
				break;
		}

		GetComponent<SpriteRenderer>().sprite = arrowSprite;
	}

	private void Update() {
		if (lifetime <= 0) Destroy(gameObject);
	}

	private void FixedUpdate() {
		transform.Translate(Velocity * arrowSpeed * Time.deltaTime * _canMove);
		lifetime -= Time.deltaTime;
	}

	private void OnTriggerEnter2D(Collider2D col) {
		if (col.CompareTag("ArrowShooter") || col.CompareTag("Arrow")) return;
		if (!col.CompareTag("Player")) {
			_canMove = 0;
			
			print(col.gameObject.name);
			
			if (!col.CompareTag("Arrow"))
				transform.SetParent(col.transform);
		}
		else {
			if (_canMove != 0)
				StartCoroutine(FindObjectOfType<GameManager>().DefeatSequence());
		}
	}
}