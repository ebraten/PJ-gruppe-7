using UnityEngine;
using System.Collections;

public class PendantFound : MonoBehaviour {

	void OnMouseDown () {
		int i = ItemListGUI.getCount();
		if (i > 0)
			Application.LoadLevel(3);
		else
			Application.LoadLevel(1);
	}
}
