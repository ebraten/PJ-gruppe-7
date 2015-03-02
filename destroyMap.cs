using UnityEngine;
using System.Collections;

public class destroyMap : MonoBehaviour {

	void OnMouseDown()
	{
		GettingObjectMap.show = true;
		getMap.map = true;
		Destroy(gameObject);
	}
}
