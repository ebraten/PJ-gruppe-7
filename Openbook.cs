using UnityEngine;
using System.Collections;

public class Openbook : MonoBehaviour {
	
	public static bool open = false;
	
	void Awake() {
		renderer.enabled = false;
	}
	
	void Update() {
		if (open)
			renderer.enabled = true;
	}
}