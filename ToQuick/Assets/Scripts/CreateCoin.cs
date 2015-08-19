using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CreateCoin : MonoBehaviour {
	public GameObject initialBlueCoin;
	public float timeForNewBlueCoin;
	private float currentBlueTime = 0.0f;
	private Vector3 initialBlueCoinPos;
	List<GameObject> newBlueCoin = new List<GameObject>();

	// Use this for initialization
	void Start () {
		newBlueCoin.Add (initialBlueCoin);
		initialBlueCoinPos = initialBlueCoin.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		createNewBlueCoin ();
		StartCoroutine (removeNullElsFromList (newBlueCoin));
	}

	void createNewBlueCoin() {
		if (Time.time - currentBlueTime > timeForNewBlueCoin) {
			currentBlueTime = Time.time;
			newBlueCoin.Add(Instantiate (newBlueCoin[newBlueCoin.Count - 1], new Vector3 (initialBlueCoinPos.x, initialBlueCoinPos.y + randomYOffset(), initialBlueCoinPos.z), Quaternion.identity )as GameObject);
				newBlueCoin[newBlueCoin.Count - 1].name = "BlueCoin" + newBlueCoin.Count;
		}
	}

	float randomYOffset() {
		return Random.Range (-4f, 4f);
	}

	IEnumerator removeNullElsFromList(List<GameObject> list) {
		yield return new WaitForSeconds (30.0f);
		list.RemoveAll (item => item == null);
	}
}
