using UnityEngine;
using System.Collections;

public class JetPack : MonoBehaviour {
	
	public float forceMultiplier = 1000f;
	
	void Update() {
		if (Input.GetButton("space")) {
			rigidbody2D.AddRelativeForce(Vector2.up * forceMultiplier * Time.deltaTime);
		}
	}

}
