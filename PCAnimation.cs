using UnityEngine;
using System.Collections;

public class PCAnimation : MonoBehaviour {
	
	bool walkingRight = true;
	Animator anim;

	// Use this for initialization
	void Start () {
	anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}
	
	void Flip () {
		walkingRight = !walkingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
