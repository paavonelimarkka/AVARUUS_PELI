using UnityEngine;
using System.Collections;

public class LeftArmRocket : MonoBehaviour {

	public float forceMultiplier = 1000f;
	public ParticleSystem particles;

	void Update() {
		if (Input.GetButton("d")) {
			rigidbody2D.AddRelativeForce(Vector2.right * -forceMultiplier * Time.deltaTime);
		}
		if (Input.GetButtonDown("d")) {
			particles.Emit(20);
		}
		if (Input.GetButtonUp("d")) {
			particles.Emit(0);
		}
	}

}
