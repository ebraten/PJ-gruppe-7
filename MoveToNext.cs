using UnityEngine;
using System.Collections;

public class MoveToNext : MonoBehaviour {
	void OnMouseDown () {
		//Moves to another scene
		Application.LoadLevel(tag);
	}
}
