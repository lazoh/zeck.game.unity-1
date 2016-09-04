using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class deathmenu : MonoBehaviour {

	private playercontroller player;
	private objectcontroller box;
	public GameObject DeathMenu;

	public GameObject timeleft;

	private scorekeeping score;

	public Text endscore;

	void Start(){
		score = FindObjectOfType<scorekeeping> ();
		box = FindObjectOfType<objectcontroller> ();
		player = FindObjectOfType<playercontroller>();	
	}

	// Use this for initialization
	public void RestartGame() {
		DeathMenu.SetActive (false);
		Application.LoadLevel(Application.loadedLevel);
		StartCoroutine (unfreezeall ());
	}
	
	public void GotoMainMenu(){
		DeathMenu.SetActive (false);
		Application.LoadLevel("MainMenu");
	}

	public IEnumerator unfreezeall(){

		Time.timeScale = 1;
		yield return new WaitForSeconds (1f);

		box.moveforwardspeed = 1f;
		player.movespeed = -2f;


	}

	public void enabledeathmenu(){
		timeleft.SetActive (false);
		DeathMenu.SetActive (true);
		endscore.text = "Score: " + (score.score + score.endscore);
	}
}
