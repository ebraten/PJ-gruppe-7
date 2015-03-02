using UnityEngine;
using System.Collections;

public class Quest : MonoBehaviour {
	public static bool drawQuest = true;

	// Use this for initialization
	void Start () {
		renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (drawQuest)
			renderer.enabled = true;
		else
			renderer.enabled = false;
	}
}
