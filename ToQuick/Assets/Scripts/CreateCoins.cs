using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class CreateCoins : MonoBehaviour {

	public GameObject initialBlueCoin;
	public float timeForNewBlueCoin;
	private float currentBlueTime = 0.0f;
	private Vector3 initialBlueCoinPos;
	List<GameObject> newBlueCoin = new List<GameObject>();

	public GameObject initialAnanasCoin;
	public float timeForAnanasCoin;
	private float currentAnanasTime = 0.0f;
	private Vector3 initialAnanasCoinPos;
	List<GameObject> newAnanasCoin = new List<GameObject>();

	public GameObject initialRedCoin;
	public float timeForNewRedCoin;
	private float currentRedTime = 0.0f;
	private Vector3 initialRedCoinPos;
	List<GameObject> newRedCoin = new List<GameObject>();

	public GameObject initialBlackCoin;
	public float timeForNewBlackCoin;
	private float currentBlackTime = 0.0f;
	private Vector3 initialBlackCoinPos;
	List<GameObject> newBlackCoin = new List<GameObject>();

	public GameObject initialYellowCoin;
	public float timeForNewYellowCoin;
	private float currentYellowTime = 0.0f;
	private Vector3 initialYellowCoinPos;
	List<GameObject> newYellowCoin = new List<GameObject>();

	public GameObject initialGreenCoin;
	public float timeForNewGreenCoin;
	private float currentGreenTime = 0.0f;
	private Vector3 initialGreenCoinPos;
	List<GameObject> newGreenCoin = new List<GameObject>();

	// Use this for initialization
	void Start () {

		newBlueCoin.Add (initialBlueCoin);
		initialBlueCoinPos = initialBlueCoin.transform.position;

		newAnanasCoin.Add (initialAnanasCoin);
		initialAnanasCoinPos = initialAnanasCoin.transform.position;

		newRedCoin.Add (initialRedCoin);
		initialRedCoinPos = initialRedCoin.transform.position;

		newBlackCoin.Add (initialBlackCoin);
		initialBlackCoinPos = initialBlackCoin.transform.position;

		newYellowCoin.Add (initialYellowCoin);
		initialYellowCoinPos = initialYellowCoin.transform.position;
	
		newGreenCoin.Add (initialGreenCoin);
		initialGreenCoinPos = initialGreenCoin.transform.position;

	}
	
	// Update is called once per frame
	void Update () {
	
		createNewBlueCoin ();
		StartCoroutine (removeNullElsFromList (newBlueCoin));

		createAnanasCoin ();
		StartCoroutine (removeNullElsFromList (newAnanasCoin));

		createNewRedCoin ();
		StartCoroutine (removeNullElsFromList (newRedCoin));

		createNewBlackCoin ();
		StartCoroutine (removeNullElsFromList (newBlackCoin));

		createNewYellowCoin ();
		StartCoroutine (removeNullElsFromList (newYellowCoin));

		createNewGreenCoin ();
		StartCoroutine (removeNullElsFromList (newGreenCoin));

	}

	void createNewBlueCoin() {
		if (Time.time - currentBlueTime > timeForNewBlueCoin) {
			currentBlueTime = Time.time;
			newBlueCoin.Add(Instantiate (newBlueCoin[newBlueCoin.Count - 1], new Vector3 (initialBlueCoinPos.x, initialBlueCoinPos.y + randomYOffset(), initialBlueCoinPos.z), Quaternion.identity )as GameObject);
			newBlueCoin[newBlueCoin.Count - 1].name = "BlueCoin" + newBlueCoin.Count;
		}
	}

	void createAnanasCoin() {
		if (Time.time - currentAnanasTime > timeForAnanasCoin) {
			currentAnanasTime = Time.time;
			newAnanasCoin.Add(Instantiate (newAnanasCoin[newAnanasCoin.Count - 1], new Vector3 (initialAnanasCoinPos.x, initialAnanasCoinPos.y + randomYOffset(), initialAnanasCoinPos.z), Quaternion.identity )as GameObject);
			newAnanasCoin[newAnanasCoin.Count - 1].name = "AnanasCoin" + newAnanasCoin.Count;
		}
	}

	void createNewRedCoin() {
		if (Time.time - currentRedTime > timeForNewRedCoin) {
			currentRedTime = Time.time;
			newRedCoin.Add(Instantiate (newRedCoin[newRedCoin.Count - 1], new Vector3 (initialRedCoinPos.x, initialRedCoinPos.y + randomYOffset(), initialRedCoinPos.z), Quaternion.identity )as GameObject);
			newRedCoin[newRedCoin.Count - 1].name = "GreenCoin" + newRedCoin.Count;
		}
	}

	void createNewBlackCoin() {
		if (Time.time - currentBlackTime > timeForNewBlackCoin) {
			currentBlackTime = Time.time;
			newBlackCoin.Add(Instantiate (newBlackCoin[newBlackCoin.Count - 1], new Vector3 (initialBlackCoinPos.x, initialBlackCoinPos.y + randomYOffset(), initialBlackCoinPos.z), Quaternion.identity )as GameObject);
			newBlackCoin[newBlackCoin.Count - 1].name = "GreenCoin" + newBlackCoin.Count;
		}
	}

	void createNewYellowCoin() {
		if (Time.time - currentYellowTime > timeForNewYellowCoin) {
			currentYellowTime = Time.time;
			newYellowCoin.Add(Instantiate (newYellowCoin[newYellowCoin.Count - 1], new Vector3 (initialYellowCoinPos.x, initialYellowCoinPos.y + randomYOffset(), initialYellowCoinPos.z), Quaternion.identity )as GameObject);
			newYellowCoin[newYellowCoin.Count - 1].name = "YellowCoin" + newYellowCoin.Count;
		}
	}

	void createNewGreenCoin() {
		if (Time.time - currentGreenTime > timeForNewGreenCoin) {
			currentGreenTime = Time.time;
			newGreenCoin.Add(Instantiate (newGreenCoin[newGreenCoin.Count - 1], new Vector3 (initialGreenCoinPos.x, initialGreenCoinPos.y + randomYOffset(), initialGreenCoinPos.z), Quaternion.identity )as GameObject);
			newGreenCoin[newGreenCoin.Count - 1].name = "GreenCoin" + newGreenCoin.Count;
		}
	}

	float randomYOffset() {
		return Random.Range (-8f, 8f);
	}
	
	IEnumerator removeNullElsFromList(List<GameObject> list) {
		yield return new WaitForSeconds (30.0f);
		list.RemoveAll (item => item == null);
	}
}

























