using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour {
	private static int _flagCount = 0;


	public Sprite inactive;
	public Sprite active;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) {
			_flagCount += 1;
			GetComponent<SpriteRenderer>().sprite = active;
		}

		if (_flagCount == 2) {
			Debug.Log("Vous avez gagné !");
			FindObjectOfType<GameManager>().LoadNextLevel();
			_flagCount = 0;
		}
    }

	private void OnTriggerExit2D(Collider2D other) {
		if (other.CompareTag("Player")) {
			_flagCount -= 1;
			GetComponent<SpriteRenderer>().sprite = inactive;
		}
	}
}
