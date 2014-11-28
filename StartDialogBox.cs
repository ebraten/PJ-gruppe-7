using UnityEngine;
using System.Collections;

public class StartDialogBox : MonoBehaviour {

	public Texture2D texture;
	public string textField;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown () {
		DialogBox.DrawGUI(textField, texture);
		Bygning.oldLady = true;
	}
}
