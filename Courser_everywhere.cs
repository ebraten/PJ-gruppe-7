using UnityEngine;
using System.Collections;

public class Courser_everywhere : MonoBehaviour {
	
	public Texture2D glas;
	private int cursorWidth = 65;
	private int cursorHeight = 65;

	// Use this for initialization
	void Start () {
		Screen.showCursor = false;
	}

	void OnGUI(){
		GUI.DrawTexture (new Rect (Input.mousePosition.x - 20, Screen.height - Input.mousePosition.y - 20, cursorWidth, cursorHeight), glas);
	}
}
