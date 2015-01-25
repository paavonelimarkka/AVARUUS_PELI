using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class JetPack : MonoBehaviour {
	
	public float forceMultiplier = 1000f;
	public AudioSource meteoriosuu;
	
	void Update() {
		if (Input.GetButton("space")) {
			rigidbody2D.AddRelativeForce(Vector2.up * forceMultiplier * Time.deltaTime);
		}
	}
	
}