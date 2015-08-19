using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CreateBlackCoin : MonoBehaviour {
	public GameObject initialBlackCoin;
	public float timeForNewBlackCoin;
	private float currentBlackTime = 0.0f;
	private Vector3 initialBlackCoinPos;
	List<GameObject> newBlackCoin = new List<GameObject>();
	
	// Use this for initialization
	void Start () {
		newBlackCoin.Add (initialBlackCoin);
		initialBlackCoinPos = initialBlackCoin.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		createNewBlackCoin ();
		StartCoroutine (removeNullElsFromList (newBlackCoin));
	}
	
	void createNewBlackCoin() {
		if (Time.time - currentBlackTime > timeForNewBlackCoin) {
			currentBlackTime = Time.time;
			newBlackCoin.Add(Instantiate (newBlackCoin[newBlackCoin.Count - 1], new Vector3 (initialBlackCoinPos.x, initialBlackCoinPos.y + randomYOffset(), initialBlackCoinPos.z), Quaternion.identity )as GameObject);
			newBlackCoin[newBlackCoin.Count - 1].name = "GreenCoin" + newBlackCoin.Count;
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
