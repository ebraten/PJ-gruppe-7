using UnityEngine;
using System.Collections;

public class Loadgame : MonoBehaviour {
	public Texture loadButton;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI () {
		//float x = (Screen.width - newButton.width)*0.5f;
		if(GUI.Button(new Rect(Screen.width / 2 - 65,Screen.height / 2 + 80,130,25), loadButton))
			Debug.Log("Load not yet implemented");
			//Go to next last scene
	}
}
