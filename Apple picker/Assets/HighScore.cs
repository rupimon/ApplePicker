﻿using UnityEngine;
using System.Collections;

public class HighScore : MonoBehaviour {
	static public int score = 1000;
	// Use this for initialization
	void Awake() {
		//If the ApplePickerHighScore already exists, read it
		if (PlayerPrefs.HasKey ("ApplePickerHighScore")) {
			score = PlayerPrefs.GetInt("ApplePickerHighScore");
		}
		// Assign the high score to ApplePickerHighScore
		PlayerPrefs.SetInt ("ApplePickerHighScore", score);
	}
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GUIText gt = this.GetComponent<GUIText> ();
		gt.text = "High Score: " + score;
		// Update ApplePickerHighScore in PlayerPrefs if necessary
		if (score > PlayerPrefs.GetInt ("ApplePickerHighScore")) {
			PlayerPrefs.SetInt ("ApplePickerHighScore", score);
		}
	}
}
