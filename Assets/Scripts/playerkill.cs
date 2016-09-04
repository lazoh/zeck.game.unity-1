using UnityEngine;
using System.Collections;

public class playerkill : MonoBehaviour {

	private playercontroller player;
	private objectcontroller box;
	private deathmenu dm;

	void  Start () {
		dm = FindObjectOfType<deathmenu> ();
		box = FindObjectOfType<objectcontroller> ();
		player = FindObjectOfType<playercontroller>();	
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			Debug.Log ("test1");

			box.moveforwardspeed = 0f;
			player.movespeed = 0f;
			player.killplayer ();
			dm.enabledeathmenu ();
		}
	}

	void Update () {
	
	}
		
}