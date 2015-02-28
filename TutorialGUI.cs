using UnityEngine;
using System.Collections;

public class TutorialGUI : MonoBehaviour {
	public Texture2D quest;
	public static bool drawGUI;
	public bool temp;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (temp)
			drawGUI = true;
		else
			drawGUI = false;
	}
	void OnGUI () {
		if (drawGUI)
			GUI.Label (new Rect(Screen.width / 2 - 310,100,625,625),quest);
	}
}
