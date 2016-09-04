using UnityEngine;
using System.Collections;

public class FauxGravityAttractor : MonoBehaviour {

	public float gravity = -10f;

	private Rigidbody rbody;

	void Start () {
		rbody = GetComponent<Rigidbody> ();
	}


	public void Attract(Transform body){
		Vector3 gravityUp = (body.position - transform.position).normalized;
		Vector3 bodyUp = body.transform.up;

		body.GetComponent<Rigidbody> ().AddForce (gravityUp * gravity);

		body.rotation = Quaternion.FromToRotation(bodyUp, gravityUp) * body.rotation;
	}
}
