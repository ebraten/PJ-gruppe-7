using UnityEngine;
using System.Collections;

public class GettingObjectiveForstorr : MonoBehaviour {

	public static bool show = false;
	
	void Awake() {
		renderer.enabled = false;
	}
	
	void Update () {
		if (show)
			renderer.enabled = true;
	}
}
