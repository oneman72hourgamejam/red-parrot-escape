using UnityEngine;
using System.Collections;

public class TimerScript : MonoBehaviour {
	public Font f;
	// Use this for initialization
	void OnGUI () {
		GUI.skin.font = f;
		GUILayout.Label ("w");
		GUILayout.Button ("w");
		GUI.Label (new Rect (25, -2, 100, 30), "Time: " + Time.time);
	}
}
