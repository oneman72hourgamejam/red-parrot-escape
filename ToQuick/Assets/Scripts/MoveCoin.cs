using UnityEngine;
using System.Collections;

public class MoveCoin : MonoBehaviour {
	public Vector2 coinSpeed = new Vector2 (0f, 2.5f);
	private float maxCoinSpeedDeviation;

	// Use this for initialization
	void Awake () {
		maxCoinSpeedDeviation = 1.5f;
	}

	// Update is called once per frame
	void Start () {
		rigidbody2D.velocity = new Vector2 (Random.Range (-maxCoinSpeedDeviation, maxCoinSpeedDeviation), coinSpeed.y);
	}
}
