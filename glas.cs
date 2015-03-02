using UnityEngine;
using System.Collections;

public class glas : MonoBehaviour 
{
	void OnMouseDown() {
		Courser.showHand = false;
		Courser.showGlas = true;
	}
}