using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerTrap : MonoBehaviour
{
    public string CurrentScene;
    GameObject[] players;
    public Animator DeathAnim;
    private void Start()
    {
        players = GameObject.FindGameObjectsWithTag("Player");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(Defeat_Sequence());
            Debug.Log("Défaite");
            
           
        }
    }

    IEnumerator Defeat_Sequence()
    {
        foreach(GameObject _player in players)
            {
                _player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
            }
        DeathAnim.SetBool("IsDead", true);
        yield return new WaitForSeconds(2f);
        DeathAnim.SetBool("IsDead", false);
        Debug.Log("Chargement de la nouvelle scene");
    }
}
