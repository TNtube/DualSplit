using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour {
	private static int _flagCount = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) {
			_flagCount += 1;
			GetComponent<SpriteRenderer>().color = Color.red;
		}

		if (_flagCount == 2) {
			Debug.Log("Vous avez gagné !");
		}
    }

	private void OnTriggerExit2D(Collider2D other) {
		if (other.CompareTag("Player")) {
			_flagCount -= 1;
			GetComponent<SpriteRenderer>().color = Color.white;
		}
	}
}
