using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour {
	public bool isEnd;
	
    // Start is called before the first frame update
	void Start() {
		if (!TryGetComponent(out Button button)) return;
        button.onClick.AddListener(() => {
			print("hello world");
			FindObjectOfType<GameManager>().LoadNextLevel();
		});
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetButtonDown("Jump")) {
			if (!isEnd)
				FindObjectOfType<GameManager>().LoadNextLevel();
			else
				SceneManager.LoadScene(0);
		}
    }

	public void PRINT() {
		print("Hello");
	}
}
