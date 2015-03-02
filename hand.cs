using UnityEngine;
using System.Collections;

public class hand : MonoBehaviour 
{
	void OnMouseDown() {
		Courser.showHand = true;
		Courser.showGlas = false;
	}
}