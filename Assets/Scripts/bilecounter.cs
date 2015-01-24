using UnityEngine;
using System.Collections;

public class bilecounter : MonoBehaviour {


	void Start () {
		StartCoroutine(BileCounter());
	}


	IEnumerator BileCounter() {
		yield return new WaitForSeconds(24);
		Application.LoadLevel("MainScene");
	}
	
}
