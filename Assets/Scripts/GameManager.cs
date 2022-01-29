using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour {
	
	private GameObject[] _players;
	public Animator deathAnim;
	private static readonly int IsDead = Animator.StringToHash("IsDead");
	private void Start()
	{
		_players = GameObject.FindGameObjectsWithTag("Player");
	}
	
	public IEnumerator DefeatSequence()
	{
		foreach(GameObject player in _players)
		{
			player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
		}
		deathAnim.SetBool(IsDead, true);
		yield return new WaitForSeconds(2f);
		deathAnim.SetBool(IsDead, false);
		Debug.Log("Chargement de la nouvelle scene");
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public void LoadNextLevel() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}