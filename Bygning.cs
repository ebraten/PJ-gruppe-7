using UnityEngine;
using System.Collections;

public class Bygning : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D col)
	{
			Destroy(this.gameObject);
	}
}
