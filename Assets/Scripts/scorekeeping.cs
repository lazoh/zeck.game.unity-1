﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scorekeeping : MonoBehaviour {

	public float score;
	public float endscore;

	private playercontroller player;

	public Text timeleft;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<playercontroller> ();
		timeleft.text = "Time remaining: " + score.ToString () + "s";
		InvokeRepeating ("scorekeeper", 1, 1);
	}
	
	// Update is called once per frame
	void Update () {
		if (score == 0)
			player.killplayer ();
	}

	void scorekeeper(){
		score -= 1;
		Debug.Log ("Score: " + score);
		timeleft.text = "Time remaining: " + score.ToString () + "s";
		endscore += 4;
	}
}
