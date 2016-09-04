using UnityEngine;
using System.Collections;

public class playerhelp : MonoBehaviour {

	private scorekeeping score;

	void  Start () {
		score = FindObjectOfType<scorekeeping> ();
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			Destroy (gameObject);
			score.score += 10f;
		}
	}
		
}