using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mud : MonoBehaviour
{
    float StartSpeed;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartSpeed = collision.gameObject.GetComponent<PlayerController>().speed;
            collision.gameObject.GetComponent<PlayerController>().speed = 50f;


        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            collision.gameObject.GetComponent<PlayerController>().speed = StartSpeed;


        }
    }

}
