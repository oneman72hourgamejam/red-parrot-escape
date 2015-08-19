using UnityEngine;
using System.Collections;

public class RestartButton : MonoBehaviour {


    public GUISkin racingGUISkin;
    public Vector2 buttonRestLocation;
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
        if(GUI.Button(new Rect(center.offset.x + buttonRestLocation.x, center.offset.y +buttonRestLocation.y, 270, 90), ""))
        {
            Debug.Log("!");
        }

    }
}
