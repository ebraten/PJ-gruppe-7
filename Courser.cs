using UnityEngine;
using System.Collections;

public class Courser : MonoBehaviour {
	
	public static bool showGlas = false;
	public static bool showHand = false;
	
	public Texture2D glas;
	public Texture2D hand;
	
	private int cursorWidth = 65;
	private int cursorHeight = 65;
	
	void OnGUI()
	{
		if (showGlas)
		{
			Screen.showCursor = false;
			
			GUI.DrawTexture (new Rect (Input.mousePosition.x - 20, Screen.height - Input.mousePosition.y - 20, cursorWidth, cursorHeight), glas);
		}

		if (showHand)
		{
			Screen.showCursor = false;
			
			GUI.DrawTexture (new Rect (Input.mousePosition.x - 20, Screen.height - Input.mousePosition.y - 20, cursorWidth, cursorHeight), hand);
		}

		else
		{
			showHand = true;
		}
	}
	
	void OnMouseDown()
	{
		if (showGlas)
		{
			showHand = false;
			GUI.DrawTexture (new Rect (Input.mousePosition.x - 20, Screen.height - Input.mousePosition.y - 20, cursorWidth + 20, cursorHeight + 20), glas);
		}
		
		else if (showHand)
		{
			GUI.DrawTexture (new Rect (Input.mousePosition.x - 20, Screen.height - Input.mousePosition.y - 20, cursorWidth + 20, cursorHeight + 20), hand);
		}
	}
}