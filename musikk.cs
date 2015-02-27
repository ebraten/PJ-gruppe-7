using UnityEngine;
using System.Collections;

public class musikk : MonoBehaviour {

	static bool AudioBegin = false;
	
	void Awake()
	{
		if (!AudioBegin) {
			audio.Play ();
			DontDestroyOnLoad (gameObject);
			AudioBegin = true;
		}
	}
	// any other methods you need
}
