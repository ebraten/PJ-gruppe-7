using UnityEngine;
using System.Collections;

public class MoveToNext : MonoBehaviour {
	public int unlockedAfter;
	
	void OnMouseDown () {
		//Moves to another scene
		if (PlayerPrefs.GetInt("Buildings") >= unlockedAfter)
			Application.LoadLevel(tag);
	}
}
