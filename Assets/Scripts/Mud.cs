using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mud : MonoBehaviour
{
    Collider2D character;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            character = collision;
            StartCoroutine(Stuck());
        }
    }

    IEnumerator Stuck()
    {
        Debug.Log("La boue");
        character.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
        yield return new WaitForSeconds(2f);
        character.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
        character.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
    }
}
