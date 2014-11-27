using UnityEngine;
using System.Collections;

public class ClickItem : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//addtogui.add(this.gameObject.name);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnMouseDown () {
		ItemListGUI.add(this.gameObject.name);
		Destroy(this.gameObject);
	}
}
