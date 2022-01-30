using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	public float speed;
	
	private float _axisX;
	private float _axisY;

	public bool mirroredPlayer;
	public bool isMirror;

	private Animator character_Animator;

    private void Start()
    {
		character_Animator = gameObject.GetComponent<Animator>();  
    }
    // Update is called once per frame
    void Update() {
		_axisX = Input.GetAxis("Horizontal");
		_axisY = Input.GetAxis("Vertical");
		if(_axisX!=0 || _axisY != 0)
        {
            if (isMirror&&mirroredPlayer)
            {
				character_Animator.SetFloat("X", -_axisX);
				character_Animator.SetFloat("Y", -_axisY);
			}
            else
            {
			   character_Animator.SetFloat("X", _axisX);
			   character_Animator.SetFloat("Y", _axisY);
            }
			character_Animator.SetBool("IsWalking", true);
			

        }
        if(_axisX == 0 && _axisY == 0)
        {
			character_Animator.SetBool("IsWalking", false);

		}
		if (Input.GetButtonDown("Jump") && SceneManager.GetActiveScene().buildIndex >= 3) {
			isMirror = !isMirror;
		}

		if (Input.GetButtonDown("Cancel")) {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}

	private void FixedUpdate() {
		GetComponent<Rigidbody2D>().velocity = 
			new Vector2(_axisX * speed * Time.deltaTime * (isMirror && mirroredPlayer ? -1f : 1f), 
				_axisY * speed * Time.deltaTime);
	}
   
}
