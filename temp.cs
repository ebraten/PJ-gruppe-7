using UnityEngine;
using System.Collections;

public class temp : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI () {
		if (GUI.Button (new Rect (0,0,75,25), "Reset")) {
				//Reset game
				PlayerPrefs.DeleteAll();
				Application.LoadLevel(0);
			}
	}
}
