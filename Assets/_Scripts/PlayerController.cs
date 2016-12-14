using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float restartDelay = 0.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Pick Up") {
			Invoke ("Restart", restartDelay);
			enabled = false;
		} else if (other.tag == "Finish") {
			Invoke ("GameOver", restartDelay);
		}
	}

	private void Restart() {
		Application.LoadLevel (Application.loadedLevel);
	}

	public void GameOver() {
		GameManager.instance.GameOver ();
	}
}
