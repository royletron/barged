using UnityEngine;
using System.Collections;

public class SimpleMovement : MonoBehaviour {
	public float speed = 10.0F;
	public float rotateSpeed = 1.0F;
	void Update() {
		transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);
		//Debug.Log (Vector3.right * 2);
		if (Input.GetAxis ("Vertical") > 0) {
				Vector3 m = Vector3.left * speed;
				rigidbody.AddRelativeForce (m);
		}
	}
}
