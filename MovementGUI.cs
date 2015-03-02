using UnityEngine;
using System.Collections;
public class Movement : MonoBehaviour {

	public float speed = 1.5f;
	private Vector3 target;
	private Vector3 currentDirection = Vector3.zero;
	
	void OnCollisionEnter2D(Collision2D col)
	{
		currentDirection = Vector3.zero;
		this.rigidbody2D.velocity = Vector3.zero;
		//This is new
		Quest.drawQuest = true;
	}

	void Start () {
		target = transform.position;
	}

	void Update () {
		//This is new and goes around entire Update
		if (!Quest.drawQuest /*or*/ !Closedbook.open){
		if (currentDirection.Equals(Vector3.zero))
		{
			Vector3 inputDirection = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
			if (!inputDirection.Equals(Vector3.zero))
			{
				currentDirection = inputDirection;
				this.rigidbody2D.velocity = currentDirection * speed;
			}
		}

		if (Input.GetMouseButtonDown(0)) {
			target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			target.z = transform.position.z;
		}
		transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
	}
	}
}
