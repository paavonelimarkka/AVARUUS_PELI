using UnityEngine;
using System.Collections;

public class boundary : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D sika) {
		if (sika.gameObject.CompareTag("Player")) {
			Application.LoadLevel("gameover");
		}
	}
}
