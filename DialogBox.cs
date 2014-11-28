using UnityEngine;
using System.Collections;

public class DialogBox : MonoBehaviour {
	private static bool drawGUI = false;
	private static string value;
	private static Texture2D portrait;
	public Texture2D background;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public static void DrawGUI (string textField, Texture2D inputImage) {
		value = textField;
		portrait = inputImage;
		drawGUI = true;
	}
	
	void OnGUI () {
		if (drawGUI) {
			GUI.Label (new Rect(Screen.width / 2 - 410,Screen.height / 2 - 200, 800,600),background);
			GUI.Label (new Rect(Screen.width / 2 - 250,Screen.height / 2 - 75, 121, 147),portrait);
			GUI.Label (new Rect(Screen.width / 2,Screen.height / 2 - 100, 300, 200),"<color=black>" + value + "</color>");
			if (GUI.Button (new Rect (Screen.width / 2 - 37,Screen.height / 2 + 50,75,25), "Next")) {
				drawGUI = false;
			}
		}
	}
}
