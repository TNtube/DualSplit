using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		print(GetComponent<Button>().transform.GetChild(0).GetComponent<Text>().text);
        GetComponent<Button>().onClick.AddListener(() => {
			print("hello world");
			FindObjectOfType<GameManager>().LoadNextLevel();
		});
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetButtonDown("Jump")) {
			FindObjectOfType<GameManager>().LoadNextLevel();
		}
    }

	public void PRINT() {
		print("Hello");
	}
}
