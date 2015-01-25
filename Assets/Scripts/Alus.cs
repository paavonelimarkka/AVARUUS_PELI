using UnityEngine;
using System.Collections;

public class Alus : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D sika) {
		if (sika.gameObject.CompareTag("Player")) {
			Application.LoadLevel("loppuruutu");
		}
	}

}
