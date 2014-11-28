using UnityEngine;
using System.Collections;

public class Bygning : MonoBehaviour {
	public static bool oldLady = false;

	void OnMouseDown() {
		if (oldLady)
			Application.LoadLevel(2);
    }
}
