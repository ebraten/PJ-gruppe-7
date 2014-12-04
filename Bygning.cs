using UnityEngine;
using System.Collections;

public class Bygning : MonoBehaviour {
	//The order the buildings will be unlocked
	public int buildingNr;

	void OnMouseDown() {
		//Checks if building is unlocked
		if (PlayerPrefs.GetInt("Buildings") >= buildingNr)
			Application.LoadLevel(tag);
    }
}
