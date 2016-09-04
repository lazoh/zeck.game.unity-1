using UnityEngine;
using System.Collections;

public class FauxGravityBody : MonoBehaviour {

	public FauxGravityAttractor attractor;
	private Transform myTransfrom;
	private Rigidbody rbody;
	// Use this for initialization

	void Start () {
		rbody = GetComponent<Rigidbody> ();
		myTransfrom = GetComponent<Transform> ();

		rbody.constraints = RigidbodyConstraints.FreezeRotation;
		rbody.useGravity = false;

		myTransfrom = transform;
	}
	
	// Update is called once per frame
	void Update () {
		attractor.Attract (GetComponent<Transform> ());
	}
}
