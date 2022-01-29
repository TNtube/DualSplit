using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFlag : MonoBehaviour
{

    public GameObject objectToSpawn;

	private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") || collision.CompareTag("MovableObject"))
        {
            objectToSpawn.SetActive(true);
            GetComponent<SpriteRenderer>().color = Color.red;
        }
	}
}
