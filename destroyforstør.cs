using UnityEngine;
using System.Collections;

public class destroyforstør : MonoBehaviour {
	
	void OnMouseDown()
	{
		GettingToolForstorr.show = true;
		GettingObjectiveForstorr.show = true;
		//GettingMouse.mouse = true;
		Destroy(gameObject);
	}
}