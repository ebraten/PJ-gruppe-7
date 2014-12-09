using UnityEngine;
using System.Collections;

public class locks : MonoBehaviour {
	public int stagenr;

	void Update () {
		if (PlayerPrefs.GetInt("Buildings") >= stagenr)
			Destroy(this.gameObject);
	}
}
