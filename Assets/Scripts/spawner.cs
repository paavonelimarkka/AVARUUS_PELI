﻿using UnityEngine;
using System.Collections;

public class spawner : MonoBehaviour {


	public bool koira = true;
	public Rigidbody2D Asteroidi;
	public int meteorSpeed;
	public float minTime;
	public float maxTime;
	private Transform Spawn;


	void Start () {
		StartCoroutine(Spawner());
	}

	IEnumerator Spawner() {
		while (koira = true) {
			yield return new WaitForSeconds(Random.Range(minTime, maxTime));
			Rigidbody2D clone = (Rigidbody2D)Instantiate(Asteroidi,transform.position,transform.rotation);
			clone.AddRelativeForce(Vector2.up * meteorSpeed);
		}
	}
	
}
