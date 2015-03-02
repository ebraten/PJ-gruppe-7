using UnityEngine;
using System.Collections;

public class QuestButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		collider.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Quest.drawQuest)
			collider.enabled = true;
		else 
			collider.enabled = false;
	}
	
	void OnMouseDown () {
		Quest.drawQuest = false;
	}
}
