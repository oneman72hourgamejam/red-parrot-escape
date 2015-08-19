using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour {


    public GUISkin racingGUISkin;
    public Vector2 buttonPauseLocation;
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
        if(GUI.Button(new Rect(center.offset.x + buttonPauseLocation.x, center.offset.y +buttonPauseLocation.y, 83, 31), ""))
        {
            Debug.Log("!");
        }

    }
}
