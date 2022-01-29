using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerTrap : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) {
            StartCoroutine(FindObjectOfType<GameManager>().DefeatSequence());
            Debug.Log("Défaite");
		}
    }
}
