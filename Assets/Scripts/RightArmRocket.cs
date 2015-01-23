using UnityEngine;
using System.Collections;

public class RightArmRocket : MonoBehaviour {
	
	public float forceMultiplier = 1000f;

	void Update() {
		if (Input.GetButton("k")) {
			rigidbody2D.AddRelativeForce(Vector2.right * forceMultiplier * Time.deltaTime);
		}
	}

}
