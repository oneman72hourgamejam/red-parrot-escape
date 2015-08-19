using UnityEngine;
using System.Collections;
using System;

public class HeroCollidingCoin : MonoBehaviour {

	public GUIText playerScore;
	public GUIText playerTime;
	private float timeElapsed = 0f;
	private int blueCoinValue = 1;
	private int redCoinValue = 2;
	//private int greenCoinValue = 3;
	private int blackCoinValue = -10;
	private int yellowCoinValue = -15;
	private int ananasValue = 3;
	private int scoreCounter = 0;


	public AudioClip blueCoinPoppingSound;
	public AudioClip redCoinPoppingSound;
	public AudioClip blackCoinPoppingSound;
	public AudioClip greenCoinPoppingSound;
	public AudioClip yellowCoinPoppingSound;
	public AudioClip ananasSound;

	private int highestScore;
	private int highestScoreOld;

	void Start() {
		//timeElapsed = 0f;

		if (PlayerPrefs.HasKey ("highestScore")) {
			highestScore = PlayerPrefs.GetInt ("highestScore");
			highestScoreOld = highestScore;
		} else {
			highestScore = 0;
			highestScoreOld = highestScore;
		}
	}

	void Update (){
		timeElapsed += Time.deltaTime;
		playerTime.text = "TIME: " + FormatTime (timeElapsed);
	}

	void OnTriggerEnter2D (Collider2D col) {
		switch (col.gameObject.tag) {
		case "BlueCoinTag":
			Destroy (col.gameObject);
			audio.PlayOneShot (blueCoinPoppingSound);
			scoreCounter += blueCoinValue;
			playerScore.text = "" + scoreCounter;
			break;
		case "RedCoinTag":
			Destroy (col.gameObject);
			audio.PlayOneShot (redCoinPoppingSound);
			scoreCounter += redCoinValue;
			playerScore.text = "" + scoreCounter;
			break;
		case "AnanasTag":
			Destroy (col.gameObject);
			audio.PlayOneShot (ananasSound);
			scoreCounter += ananasValue;
			playerScore.text = "" + scoreCounter;
			break;
		case "BlackCoinTag":
			Destroy (col.gameObject);
			audio.PlayOneShot (blackCoinPoppingSound);
			scoreCounter += blackCoinValue;
			if(scoreCounter < 0)
				gameOver(scoreCounter);
			playerScore.text = "" + scoreCounter;
			break;
		case "YellowCoinTag":
			Destroy (col.gameObject);
			audio.PlayOneShot (yellowCoinPoppingSound);
			scoreCounter += yellowCoinValue;
			if(scoreCounter < 0)
				gameOver(scoreCounter);
			playerScore.text = "" + scoreCounter;
			break;
		case "GreenCoinTag":
			Destroy (col.gameObject);
			audio.PlayOneShot (greenCoinPoppingSound);

			gameOver(scoreCounter);
			break;
		}

	}

	// Update is called once per frame
	void gameOver (int score) {
		Debug.Log ("Game Over! Your score: " + score);
		Application.LoadLevel("GameOverMenu");

		if(score > highestScore){
			highestScore = score;
		}

		PlayerPrefs.SetInt ("currentScore", score);
		PlayerPrefs.SetInt ("highestScore", highestScore);
		PlayerPrefs.SetInt ("highestScoreOld", highestScoreOld);

	}

	string FormatTime(float value) {
		//TimeSpan t = TimeSpan.FromSeconds (value);
		return value.ToString ();
		//return string.Format ("{0:D2}:{1:D2}", t.Minutes, t.Seconds);
	}
}
