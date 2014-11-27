using UnityEngine;
using System.Collections;

public class Bygning : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D col)
	{
			Application.LoadLevel(tag);
	}
}
