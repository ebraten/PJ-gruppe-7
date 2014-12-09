using UnityEngine;
using System.Collections;

public class MoveToNextFromRoom : MonoBehaviour {

	void OnMouseDown () {
		//Moves to another scene
		ItemListGUI.list.Clear();
		Application.LoadLevel(tag);
	}
}
