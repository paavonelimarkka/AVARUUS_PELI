using UnityEngine;
using System.Collections;

public class LeftFootRocket : MonoBehaviour {
	
	public float forceMultiplier = 1000f;
	
	void Update() {
		if (Input.GetButton("f")) {
			rigidbody2D.AddRelativeForce(Vector2.up * forceMultiplier * Time.deltaTime);
		}
	}
	
}
