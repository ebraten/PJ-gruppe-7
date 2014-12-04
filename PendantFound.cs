using UnityEngine;
using System.Collections;

public class PendantFound : MonoBehaviour {

	void OnMouseDown () {
		//Deprecated
		//If the items are found, it will load the next scene instead of the old
		int i = ItemListGUI.getCount();
		if (i == 0)
			Application.LoadLevel(3);
		else
			Application.LoadLevel(1);
	}
}
