using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StartDialogBox : MonoBehaviour {

	public Texture2D texture;
	public string textField;
	public List<string> dialog;
	public int itemAmount;
	bool first = true;

	void OnMouseDown () {
		//Unlocks building and starts dialog box
		if (PlayerPrefs.GetInt("Items") >= itemAmount)
			DialogBox.DrawGUI(dialog[1], texture);
		else
			DialogBox.DrawGUI(dialog[0], texture);
		if (first)
		{
			PlayerPrefs.SetInt("Buildings", PlayerPrefs.GetInt("Buildings") + 1);
			first = false;
		}
		Debug.Log(PlayerPrefs.GetInt("Buildings"));
	}
}
