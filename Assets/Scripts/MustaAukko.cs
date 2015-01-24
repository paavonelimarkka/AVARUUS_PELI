using UnityEngine;
using System.Collections;

public class MustaAukko : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter2D (Collider2D collider) {
		Application.LoadLevel("gameover");
	}

}
