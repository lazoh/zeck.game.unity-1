using UnityEngine;
using System.Collections;

public class playersave : MonoBehaviour {

	private scorekeeping score;
	private GameObject[] gameObjects;

	void  Start () {
		score = FindObjectOfType<scorekeeping> ();
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			score.score += 60f;

			killallbox ();
		}
	}

	void killallbox(){
		gameObjects = GameObject.FindGameObjectsWithTag ("Enemy");

		for(var i = 0 ; i < gameObjects.Length ; i++)
		{
			Destroy(gameObjects[i]);
		}

	}
		
}