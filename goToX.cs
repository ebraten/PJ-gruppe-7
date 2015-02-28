using UnityEngine;
using System.Collections;

public class goToX : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public static void loadStage (int stage) {
		Application.LoadLevel(stage);
	}
}
