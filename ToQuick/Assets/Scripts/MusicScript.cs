using UnityEngine;
using System.Collections;

public class MusicScript : MonoBehaviour {

	public bool CanMute;
	public GUISkin racingGUISkin;
	public Vector2 buttonMusicLocation;
	public _GUIClasses.Location center = new _GUIClasses.Location();

	// Use this for initialization
	void Start () {
		CanMute = true;
	}

	void Update ()
	{
		center.updateLocation();
	}
	// Update is called once per frame
	void OnGUI () {
		GUI.skin = racingGUISkin;
		GUI.depth = -1;
		if(GUI.Button(new Rect(center.offset.x + buttonMusicLocation.x, center.offset.y +buttonMusicLocation.y, 83, 31), ""))
		{
			if(CanMute)
			{
				AudioListener.pause = true;
				CanMute = false;
			} else {
				AudioListener.pause = false;
				CanMute = true;
			}
		}

	}
}


// Update is called once per frame

