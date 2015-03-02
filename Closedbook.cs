using UnityEngine;
using System.Collections;

public class Closedbook : MonoBehaviour {
	
	public static bool isClose = false;
	
	// Use this for initialization
	void OnMouseDown ()
	{
		renderer.enabled = false;
		Openbook.open = true;
	}
	
	void Update()
	{
		renderer.enabled = true;
	}
}
