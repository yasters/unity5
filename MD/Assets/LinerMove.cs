﻿using UnityEngine;
using System.Collections;

public class LinerMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(RePositionWithDelay());
	}
	
    IEnumerator RePositionWithDelay() {
		while (true) {
			SetPosition();
			yield return new WaitForSeconds(5);
		}
    }

	void SetPosition() {
		float x = Random.Range(-5.0f, 5.0f);
		float z = Random.Range(-5.0f, 5.0f);
		Debug.Log("X,Z: " + x.ToString("F2") + "," + z.ToString("F2"));
		transform.position = new Vector3(x, 0.0f, z);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
