using UnityEngine;
using System.Collections;

public class snakking : MonoBehaviour {

	private bool popup;

	void OnMouseDown () {
		popup = true;
	}


	void DrawInfo()
	{
		Rect close = new Rect (250,50,50,50);
		if (popup)
		{
			GUI.Box(new Rect(100, 50, 100, 50), "hey");
			if (GUI.Button (close,"X"))
			{
				popup = false;
			}
		}
	}

	void OnGUI()
	{
		DrawInfo();
	}
}
