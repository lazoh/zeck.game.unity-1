using UnityEngine;
using System.Collections;

public class playercontroller : MonoBehaviour {

	public float moveforwardspeed = 1f;
	public float movespeed = 15f;
	private Vector3 moveDir;
	public float health = 100;

	private boxgenerator generator;
	// Use this for initialization
	void Start () {
		generator = FindObjectOfType<boxgenerator> ();
	}
	
	// Update is called once per frame
	void Update () {
		moveDir = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, moveforwardspeed).normalized;
		//moveDir = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
	}

	void FixedUpdate() {
		GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + transform.TransformDirection(moveDir) * movespeed * Time.deltaTime);
	}

	public void killplayer(){
		StartCoroutine (killobject1 ());
	}

	IEnumerator killobject1(){

		Debug.Log ("test3");

		Time.timeScale = 0.1f;

		yield return new WaitForSeconds (0.05f);

		Debug.Log ("test4");

		transform.DetachChildren ();

		generator.killgenerator();

		Destroy (gameObject);

		Debug.Log ("test5");

	}
				
}
