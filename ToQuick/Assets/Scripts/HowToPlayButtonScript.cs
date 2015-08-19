using UnityEngine;
using System.Collections;

public class HowToPlayButtonScript : MonoBehaviour {

	public GUISkin racingGUISkin;
    public Vector2 buttonHLocation;
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
        if(GUI.Button(new Rect(center.offset.x + buttonHLocation.x, center.offset.y +buttonHLocation.y, 260, 80), ""))
        {
            Debug.Log("!");
        }

    }
}
