using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFlag : MonoBehaviour
{

    public GameObject object_To_Spawn;


    private void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
      {
            object_To_Spawn.SetActive(true);
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }
    }
}
