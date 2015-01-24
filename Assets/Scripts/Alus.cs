using UnityEngine;
using System.Collections;

public class Alus : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D collider) {
		Application.LoadLevel("loppuruutu");
	}

}
