using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CreateGreenCoin : MonoBehaviour {
	public GameObject initialGreenCoin;
	public float timeForNewGreenCoin;
	private float currentGreenTime = 0.0f;
	private Vector3 initialGreenCoinPos;
	List<GameObject> newGreenCoin = new List<GameObject>();
	
	// Use this for initialization
	void Start () {
		newGreenCoin.Add (initialGreenCoin);
		initialGreenCoinPos = initialGreenCoin.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		createNewGreenCoin ();
		StartCoroutine (removeNullElsFromList (newGreenCoin));
	}
	
	void createNewGreenCoin() {
		if (Time.time - currentGreenTime > timeForNewGreenCoin) {
			currentGreenTime = Time.time;
			newGreenCoin.Add(Instantiate (newGreenCoin[newGreenCoin.Count - 1], new Vector3 (initialGreenCoinPos.x, initialGreenCoinPos.y + randomYOffset(), initialGreenCoinPos.z), Quaternion.identity )as GameObject);
			newGreenCoin[newGreenCoin.Count - 1].name = "GreenCoin" + newGreenCoin.Count;
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
