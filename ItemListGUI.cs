using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemListGUI : MonoBehaviour {
	//List of items in the scene
	public static List<string> list = new List<string>();
	
	public static int getCount (){
		return list.Count;
	}
	
	void OnGUI () {
		//Lists all the items that has to be found
		int height = 35;
		foreach (string e in list) {
			GUI.Label (new Rect (30, height, 100, 100), "<color=black>Finn " + e + "</color>");
			height += 10;
		}
	}
	
	public static void add (string name) {
		Debug.Log("Added: " + name);
		list.Add(name);
	}
	
	public static void remove (string name) {
		Debug.Log("Removed: " + name);
		list.Remove(name);
	}
}
