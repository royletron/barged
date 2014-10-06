using UnityEngine;
using System.Collections;

public class SimpleMovement : MonoBehaviour {
	public float speed = 10.0F;
	public float rotateSpeed = 1.0F;
	void FixedUpdate() {
		rigidbody.AddTorque(Vector3.up * rotateSpeed * Input.GetAxis("Horizontal"));
		//Debug.Log (Vector3.right * 2);
		if (Input.GetAxis ("Vertical") > 0) {
				Vector3 m = Vector3.left * speed;
				rigidbody.AddRelativeForce (m);
		}
	}
}
