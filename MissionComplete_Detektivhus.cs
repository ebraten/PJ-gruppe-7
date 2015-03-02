using UnityEngine;
using System.Collections;

public class MissionComplete_Detektivhus : MonoBehaviour {

	// Use this for initialization
	void Start () {
		renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (GettingObjectiveForstorr.show == true && GettingObjectMap.show == true) {
			renderer.enabled = true;
		}
	}
}
