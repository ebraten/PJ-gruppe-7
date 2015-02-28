using UnityEngine;
using System.Collections;

public class GettingMouse : MonoBehaviour {

	public static bool mouse = false;
	public Texture2D cursorImage;
	private int cursorWidth = 70;
	private int cursorHeight = 70;

	void OnGUI()
	{
		if (mouse)
		{
			Screen.showCursor = false;
			
			GUI.DrawTexture (new Rect (Input.mousePosition.x - 20, Screen.height - Input.mousePosition.y - 20, cursorWidth, cursorHeight), cursorImage);
		}
	}
}
