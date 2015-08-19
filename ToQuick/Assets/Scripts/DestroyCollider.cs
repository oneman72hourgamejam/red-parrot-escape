using UnityEngine;
using System.Collections;

public class DestroyCollider : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D col) {
		switch (col.gameObject.tag) {
		case "BlueCoinTag":
			Destroy (col.gameObject);
			break;
		case "RedCoinTag":
			Destroy (col.gameObject);
			break;
		case "BlackCoinTag":
			Destroy (col.gameObject);
			break;
		case "GreenCoinTag":
			Destroy (col.gameObject);
			break;
		case "YellowCoinTag":
			Destroy (col.gameObject);
			break;
		case "AnanasTag":
			Destroy (col.gameObject);
			break;
		}
	}
}
