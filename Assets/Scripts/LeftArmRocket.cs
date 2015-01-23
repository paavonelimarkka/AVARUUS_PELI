using UnityEngine;
using System.Collections;

public class LeftArmRocket : MonoBehaviour {

	public float forceMultiplier = 1000f;

	void Update() {
		if (Input.GetButton("d")) {
			rigidbody2D.AddRelativeForce(Vector2.right * -forceMultiplier * Time.deltaTime);
		}
	}

}
