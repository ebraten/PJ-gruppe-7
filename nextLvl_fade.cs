using UnityEngine;
using System.Collections;

public class nextLvl : MonoBehaviour {
	public int unlockedAfter;
	public bool clickToGo = false;


	void OnMouseDown() {
		StartCoroutine (myCoroutine());
	}
	
	IEnumerator myCoroutine () {
		float fadeTime = GameObject.Find ("Main Camera").GetComponent<fade> ().BeginFade (1);
		yield return new WaitForSeconds (fadeTime);
		goNextLvl ();
	}

	void goNextLvl(){
		Application.LoadLevel (tag);
	}
}