using UnityEngine;
using System.Collections;

public class objectcontroller : MonoBehaviour {

	public float moveforwardspeed = 1f;
	public float movespeed = 2f;
	private Vector3 moveDir;
	public float killtimer;

	// Use this for initialization
	void Start () {
		//StartCoroutine (killobox ());
	}

	// Update is called once per frame
	void Update () {
		moveDir = new Vector3 (0, 0, moveforwardspeed).normalized;
	}

	void FixedUpdate() {
		GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + transform.TransformDirection(moveDir) * movespeed * Time.deltaTime);
	}
		
	IEnumerator killbox(){
		yield return new WaitForSeconds (killtimer);
		Destroy (gameObject);
		Debug.Log(gameObject + "has been destroyed");
	}
}
