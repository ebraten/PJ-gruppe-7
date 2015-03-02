using UnityEngine;
using System.Collections;

public class getMap : MonoBehaviour {

	public static bool map = false;

	void Awake() {
				renderer.enabled = false;
		}

	void Update () {
		if (map)
				renderer.enabled = true;
	}
}

