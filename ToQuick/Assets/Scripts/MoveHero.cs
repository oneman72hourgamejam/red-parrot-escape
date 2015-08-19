using UnityEngine;
using System.Collections;

public class MoveHero : MonoBehaviour {

	private float lastTouchTime, currentTouchTime;

	public float velocityVal;
	public float torqueVal;
	public float thresholdTime;

	// Use this for initialization
	void Awake () {
		velocityVal = 7.0f;
		torqueVal = 0.0f;
		thresholdTime = 0.3f;
	}
	
	// Update is called once per frame
	void Update () {
	
	//#if UNITY_ANDROID
		//moveHeroAndroid ();
	//#endif

	//#if UNITY_EDITOR
		moveHero ();
	//#endif
	
	}

	void moveHero() {
		Vector3 currentPos, touchedPos, distanceVec;
		if (Input.GetMouseButtonDown(0)) {
			startRotatingHeroAndStopIt();
		}

		else if (Input.GetMouseButtonUp(0)) {
			currentPos = Camera.main.WorldToScreenPoint (transform.position);
			touchedPos = Input.mousePosition;
			distanceVec = (touchedPos - currentPos).normalized;
			stopRotatingHeroAndMoveIt(distanceVec, velocityVal);
		}
	}

	void moveHeroAndroid() {
		Vector3 currentPos, touchedPos, distanceVec;
		for(int i = 0; i < Input.touches.Length; i++) {
			Touch touch = Input.GetTouch(i);
			currentPos = Camera.main.WorldToScreenPoint(transform.position);
			touchedPos = touch.position;
			distanceVec = (touchedPos - currentPos).normalized;
			if (Input.GetTouch(0).phase == TouchPhase.Began) {
				startRotatingHeroAndStopIt();
			} else if (Input.GetTouch(0).phase == TouchPhase.Ended) {
				currentTouchTime = Time.time;
				if (currentTouchTime - lastTouchTime > thresholdTime) { //No Double Touch
					lastTouchTime = Time.time;
					stopRotatingHeroAndMoveIt(distanceVec, velocityVal);
				} else if (currentTouchTime - lastTouchTime < thresholdTime) { //Double Touch
					lastTouchTime = Time.time;
					stopRotatingHeroAndMoveIt(distanceVec, velocityVal*2.0f);
				}
			}
		}
	}

	void startRotatingHeroAndStopIt() {
		//rotate hero
		rigidbody2D.fixedAngle = false;
		rigidbody2D.AddTorque (torqueVal);

		//stop rotate
		rigidbody2D.velocity = Vector2.zero;
	}

	void stopRotatingHeroAndMoveIt(Vector3 distanceVec, float velocity) {
		//stop rotate
		Quaternion heroQuatern = new Quaternion();
		heroQuatern.eulerAngles = new Vector3(0, 0, 0);
		rigidbody2D.fixedAngle = true;
		rigidbody2D.transform.rotation = heroQuatern;
	
		//move hero
		rigidbody2D.velocity = distanceVec * velocity;
	}

}



































