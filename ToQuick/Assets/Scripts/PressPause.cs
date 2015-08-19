using UnityEngine;
using System.Collections;

public class PressPause : MonoBehaviour {
	public GameObject hero;
	public GameObject pauseMenu;

	// Use this for initialization
	void Start () {
		pauseMenu.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		//#if UNITY_ANDROID
		//CheckTouchAndroid ();
		//#endif
		
		//#if UNITY_EDITOR
		CheckTouchComputer ();
		//#endif
	}

	void CheckTouchAndroid() {
		for(int i = 0; i < Input.touches.Length; i++) {
			Touch touch = Input.GetTouch(i);
			Vector3 pos = touch.position;
			RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);
			if (hit != null && hit.collider != null)
			switch(hit.collider.name) {
				case "PauseBtn":
				StartCoroutine(stopHeroFromMoving());
				Time.timeScale = 0.0f;
				pauseMenu.SetActive(true);
				break;
				case "ResumeGame":
				Time.timeScale = 1.0f;
				pauseMenu.SetActive(false);
				break;
				case "RestartGame":
				Application.LoadLevel("PlayGame");
				Time.timeScale = 1.0f;
				break;
				case "GoHome":
				Application.LoadLevel("MainMenu");
				Time.timeScale = 1.0f;
				break;
			}
		}
	}

	void CheckTouchComputer() {
		if (Input.GetMouseButtonUp(0)) {
			Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);
			if (hit != null && hit.collider != null) {
			switch(hit.collider.name) {
			case "PauseBtn":
				StartCoroutine(stopHeroFromMoving());
				Time.timeScale = 0.0f;
				pauseMenu.SetActive(true);
				break;
			case "ResumeGame":
				Time.timeScale = 1.0f;
				pauseMenu.SetActive(false);
				break;
			case "RestartGame":
				Application.LoadLevel("PlayGame");
				Time.timeScale = 1.0f;
				break;
			case "GoHome":
				Application.LoadLevel("MainMenu");
				Time.timeScale = 1.0f;
				break;
				}
			}
		}
	}

	IEnumerator stopHeroFromMoving() {
		yield return new WaitForSeconds (0.01f);
		hero.rigidbody2D.velocity = Vector2.zero;
	}
}
