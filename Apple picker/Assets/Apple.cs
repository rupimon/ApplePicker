﻿using UnityEngine;
using System.Collections;

public class Apple : MonoBehaviour {

	// Use this for initialization
	public static float bottomY = -20f;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < bottomY) {
			Destroy (this.gameObject);
		}
	}
}
