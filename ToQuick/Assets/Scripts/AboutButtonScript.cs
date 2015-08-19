using UnityEngine;
using System.Collections;

public class AboutButtonScript : MonoBehaviour {

	public GUISkin racingGUISkin;
    public Vector2 buttonALocation;
    public _GUIClasses.Location center = new _GUIClasses.Location();

    // Use this for initialization
    void Start () {

    }

    void Update ()
    {
        center.updateLocation();
    }
    // Update is called once per frame
    void OnGUI () {
        GUI.skin = racingGUISkin;
        GUI.depth = -1;
        if(GUI.Button(new Rect(center.offset.x + buttonALocation.x, center.offset.y +buttonALocation.y, 170, 60), ""))
        {
            Debug.Log("!");
        }

    }
}
