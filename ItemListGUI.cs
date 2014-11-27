using UnityEngine;
using System.Colslections;
using System.Collections.Generic;

public class ItemListGUI : MonoBehaviour {
	public static List<string> list = new List<string>();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI () {
		int height = 0;
		GUI.Box(new Rect(0,0,100,100), "List of items");
		foreach (string e in list) {
			height += 2;
			GUI.Label (new Rect (15, height * 10, 100, 100), e);
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
