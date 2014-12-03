using UnityEngine;
using System.Collections;

public class StartDialogBox : MonoBehaviour {

	public Texture2D texture;
	public string textField;
	bool first;

	void OnMouseDown () {
		//Unlocks building and starts dialog box
		DialogBox.DrawGUI(textField, texture);
		if (first)
		{
			PlayerPrefs.SetInt("Buildings", PlayerPrefs.GetInt("Buildings") + 1);
			first = false;
		}
		Debug.Log(PlayerPrefs.GetInt("Buildings"));
	}
}
