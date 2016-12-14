using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

	public float startDelay = 2f;
	public static GameManager instance = null;

	private Text scoreText;
	private GameObject backgroundImage;
	private Text backgroundText;

	// Use this for initialization
	void Awake () {
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);

		InitGame ();
	}

	void InitGame() {
		backgroundImage = GameObject.Find ("BackgroundImage");
		backgroundText = GameObject.Find ("BackgroundText").GetComponent<Text> ();
		backgroundText.text = "Find the glowing pink ball!";

		Invoke ("HideBackgroundImage", startDelay);
	}
		

	private void HideBackgroundImage() {
		backgroundImage.SetActive (false);
	}
	// Update is called once per frame
	void Update () {

	}

	public void GameOver() {
		backgroundText.text = "You win!";
		backgroundImage.SetActive (true);

		enabled = false;
	}
}
