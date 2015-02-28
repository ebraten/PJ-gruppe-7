using UnityEngine;
using System.Collections;

public class destroyforstør : MonoBehaviour {
	
	void OnMouseDown()
	{
		GettingMouse.mouse = true;
		Destroy(gameObject);
	}
}
