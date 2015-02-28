using UnityEngine;
using System.Collections;

public class Newgame : MonoBehaviour {
	public Texture newButton;
	public int stage;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI () {
		//float x = (Screen.width - newButton.width)*0.5f;
		if(GUI.Button(new Rect(Screen.width / 2 - 50,Screen.height / 2 + 40,100,25), newButton))
			goToX.loadStage(stage);
			//Deletes all progress, goes to scene 2
			/*GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
			GUILayout.FlexibleSpace();
			GUILayout.BeginHorizontal();	
			GUILayout.FlexibleSpace();
			
			GUILayout.BeginVertical("New game");
			GUILayout.Button(newButton);
			GUILayout.EndVertical();
			
			GUILayout.FlexibleSpace();
			GUILayout.EndHorizontal();
			GUILayout.FlexibleSpace();
			GUILayout.EndArea();*/
	}
}
