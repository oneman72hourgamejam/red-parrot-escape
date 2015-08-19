using UnityEngine;
using System.Collections;

public class NewGameButtonScript : MonoBehaviour {


    public GUISkin racingGUISkin;
    public Vector2 buttonNewLocation;
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
        if(GUI.Button(new Rect(center.offset.x + buttonNewLocation.x, center.offset.y +buttonNewLocation.y, 315, 100), ""))
        {
            Debug.Log("!");
        }

    }
}
