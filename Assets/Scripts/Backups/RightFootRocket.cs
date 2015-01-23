using UnityEngine;
using System.Collections;

public class RightFootRocket : MonoBehaviour {
	
	public float forceMultiplier = 1000f;
	
	void Update() {
		if (Input.GetButton("j")) {
			rigidbody2D.AddRelativeForce(Vector2.up * -forceMultiplier * Time.deltaTime);
		}
	}
	
}
