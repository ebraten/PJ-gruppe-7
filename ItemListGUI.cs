using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemListGUI : MonoBehaviour {
	public static List<string> list = new List<string>();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public static int getCount (){
		return list.Count;
	}
	
	void OnGUI () {
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
