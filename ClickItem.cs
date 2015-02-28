using UnityEngine;
using System.Collections;

public class ClickItem : MonoBehaviour {

	void Start () {
		ItemListGUI.add(this.gameObject.name);
	}


	
	void OnMouseDown () {
		ItemListGUI.remove(this.gameObject.name);
		Destroy(this.gameObject);
	}
}
