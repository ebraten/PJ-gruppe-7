using UnityEngine;
using System.Collections;

public class Quit : MonoBehaviour {

	void Awake() {
		collider.enabled = false;
	}
	
	void Update() {
		if (Closedbook.open && Closedbook.pageOne){
			renderer.enabled = true;
			collider.enabled = true;
		}else{
			renderer.enabled = false;
			collider.enabled = false;
		}
	}
	
	void OnMouseDown ()
	{
		Application.Quit();
	}
}
