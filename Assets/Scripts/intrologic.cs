using UnityEngine;
using System.Collections;

public class intrologic : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (Input.GetButton("space")) {
			Application.LoadLevel("bilekuva");
		}
	}
}
