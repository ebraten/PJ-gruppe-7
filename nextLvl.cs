using UnityEngine;
using System.Collections;

public class nextLvl : MonoBehaviour {
	public int unlockedAfter;
	
	void OnMouseDown () {
		//Moves to another scene
			Application.LoadLevel(tag);
	}
}