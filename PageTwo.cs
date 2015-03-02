using UnityEngine;
using System.Collections;

public class PageTwo : MonoBehaviour {

	void Awake() {
		renderer.enabled = false;
	}
	
	void Update() {
		if (Closedbook.open && !Closedbook.pageOne)
			renderer.enabled = true;
		else
			renderer.enabled = false;
	}
}
