using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CreateRedCoin : MonoBehaviour {
	public GameObject initialRedCoin;
	public float timeForNewRedCoin;
	private float currentRedTime = 0.0f;
	private Vector3 initialRedCoinPos;
	List<GameObject> newRedCoin = new List<GameObject>();
	
	// Use this for initialization
	void Start () {
		newRedCoin.Add (initialRedCoin);
		initialRedCoinPos = initialRedCoin.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		createNewRedCoin ();
		StartCoroutine (removeNullElsFromList (newRedCoin));
	}
	
	void createNewRedCoin() {
		if (Time.time - currentRedTime > timeForNewRedCoin) {
			currentRedTime = Time.time;
			newRedCoin.Add(Instantiate (newRedCoin[newRedCoin.Count - 1], new Vector3 (initialRedCoinPos.x, initialRedCoinPos.y + randomYOffset(), initialRedCoinPos.z), Quaternion.identity )as GameObject);
			newRedCoin[newRedCoin.Count - 1].name = "GreenCoin" + newRedCoin.Count;
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
