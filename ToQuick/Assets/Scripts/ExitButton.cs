using UnityEngine;
using System.Collections;

public class ExitButton : MonoBehaviour {


    public GUISkin racingGUISkin;
    public Vector2 buttonExitLocation;
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
        if(GUI.Button(new Rect(center.offset.x + buttonExitLocation.x, center.offset.y +buttonExitLocation.y, 175, 70), ""))
        {
            Debug.Log("!");
        }

    }
}
