using UnityEngine;
using System.Collections;

public class ClickItem : MonoBehaviour {

	void Start () {
		//Add all the clickable items to the list at the start
		ItemListGUI.add(this.gameObject.name);
	}


	
	void OnMouseDown () {
		//Removes items that are clicked
		ItemListGUI.remove(this.gameObject.name);
		Destroy(this.gameObject);
	}
}
