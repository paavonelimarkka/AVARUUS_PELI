using UnityEngine;
using System.Collections;

public class RightArmRocket : MonoBehaviour {
	
	public float forceMultiplier = 1000f;
	public ParticleSystem particles;

	void Start() {
		particleSystem.emissionRate = 0;
	}

	void Update() {
		if (Input.GetButton("k")) {
			rigidbody2D.AddRelativeForce(Vector2.right * forceMultiplier * Time.deltaTime);
		}
		if (Input.GetButtonDown("k")) {
			particles.Emit(20);
		}
		if (Input.GetButtonUp("k")) {
			particles.Emit(0);
		}
	}

}
