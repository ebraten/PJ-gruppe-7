using UnityEngine;
using System.Collections;

public class TurnPage : MonoBehaviour {

	void OnMouseDown ()
	{
		Closedbook.pageOne = !Closedbook.pageOne;
	}
	
	void Awake() {
		renderer.enabled = false;
		collider.enabled = false;
	}
	
	void Update() {
		if (Closedbook.open){
			renderer.enabled = true;
			collider.enabled = true;
		}else{
			renderer.enabled = false;
			collider.enabled = false;
		}
	}
}
